using LeetcodeManager.Controller;
using LeetcodeManager.Entity;
using LeetcodeManager.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeetcodeManager.View
{
    public partial class MasterForm : Form
    {
        private readonly ProblemInputController _problemController;
        private readonly TagInputController _tagController;
        public MasterForm()
        {
            InitializeComponent();
            _problemController = new ProblemInputController();
            _tagController = new TagInputController();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //binding to tree
            var tags = _tagController.GetAllTags();
            TreeNode root = treeViewTag.Nodes[0];
            if (tags == null) return;
            foreach (var tag in tags)
            {
                TreeNode node = new TreeNode(tag.Name) { Tag = tag };
                root.Nodes.Add(node);
            }
            treeViewTag.ExpandAll();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            //MyDb: dispose
        }

        private void newTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var input = new TagInputForm();
            if (input.ShowDialog() != DialogResult.OK)
                return;
            var tag = new Tag() { Name = input.InputTag };
            var tagdb = _tagController.GetATagByName(input.InputTag);
            if (!_tagController.IsNew(tagdb))
            {
                SysHelper.ShowMessageWarning("Existed tag with this name, create failure!");
                return;
            }
            tagdb =_tagController.SaveTagToDb(tag);
            treeViewTag.Nodes[0].Nodes.Add(new TreeNode(input.InputTag) { Tag = tagdb });
            treeViewTag.ExpandAll();
        }

        private void updateTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewTag.SelectedNode.Name == "rootNode")
            {
                MessageBox.Show("Root name cannot be revised!");
                return;
            }
            var tagdel = treeViewTag.SelectedNode.Tag as Tag;
            if (tagdel == null) return;
            var rettag = _tagController.GetATagById(tagdel.TagId);
            if (rettag == null)
            {
                SysHelper.ShowMessageWarning("Unable to retrive from db!");
                return;
            }
            var input = new TagInputForm(tagdel.Name);
            if (input.ShowDialog() != DialogResult.OK)
                return;
            rettag.Name = input.InputTag;
            _tagController.UpdateTagName(rettag);
            treeViewTag.SelectedNode.Text = input.InputTag;
            treeViewTag.ExpandAll();
        }

        private void deleteTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewTag.SelectedNode.Name == "rootNode")
            {
                MessageBox.Show("Root of tree cannot be deleted!");
                return;
            }
            try
            {
                var tagdel = treeViewTag.SelectedNode.Tag as Tag;
                if (tagdel == null) return;
                var rettag = _tagController.GetATagById(tagdel.TagId);
                if (rettag == null)
                {
                    SysHelper.ShowMessageWarning("Unable to retrive from db!");
                    return;
                }
                _tagController.DeleteTag(rettag);
                treeViewTag.SelectedNode.Remove();
                SysHelper.ShowMessageOK("deletion success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("deletion failure");
            }
            treeViewTag.ExpandAll();
        }

        private void treeViewTag_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Tag tag = e.Node.Tag as Tag;
            if (tag == null)
                return;
            if (SysHelper.CollectionNullOrEmpty<Problem>(tag.Problems))
            {
                problemBindingSource.DataSource = tag.Problems;
                return;
            }
            problemBindingSource.DataSource = tag.Problems;
        }

        //save question
        private void problemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            foreach (DataGridViewRow row in problemDataGridView.Rows)
            {
                Problem obj = row.DataBoundItem as Problem;
                if (obj == null) continue;
                _problemController.SaveProblem(obj);
            }
            _problemController.UpdateProblems(); //inlcude delete(this is the ability EF provides) 
            problemDataGridView.Refresh();
        }

        private void toolStripButtonDelAll_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (DialogResult.No == SysHelper.ShowMessageYesOrNo("Are you sure to delete all problems in this grid?"))
                return;
            problemBindingSource.DataSource = new List<Problem>();
        }

        private void deleteALLLocalDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Are you sure to delete all data in database?", "LeetCodeManager", MessageBoxButtons.YesNo))
                return;
            IList<Problem> deletes = new List<Problem>();
            foreach(DataGridViewRow row in problemDataGridView.Rows)
            {
                var problem = row.DataBoundItem as Problem;
                if(problem!=null && !_problemController.IsNew(problem))
                     deletes.Add(problem);
            }
            _problemController.DeleteProblems(deletes);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ProblemInputForm problemInput = new ProblemInputForm();
            if (problemInput.ShowDialog() == DialogResult.Cancel)
                return;
            Problem newproblem = problemInput.InputProblem;
            int cnt = problemDataGridView.Rows.Count;
            DataGridViewRow fillrow = problemDataGridView.Rows[cnt - 2];
            fillrow.Cells[1].Value = newproblem.Title;
            fillrow.Cells[2].Value = newproblem.LtUrl;
            fillrow.Cells[3].Value = newproblem.CsdnAddress;
            fillrow.Cells[4].Value = newproblem.Content;
            fillrow.Cells[5].Value = newproblem.Tags;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            var selectrows = problemDataGridView.SelectedRows;
            if(selectrows==null || selectrows.Count==0)
            {
                SysHelper.ShowMessageWarning("unselect any row, please select at least one row!");
                return;
            }
            foreach(DataGridViewRow row in selectrows)
            {
                var frm = new ProblemInputForm(row.DataBoundItem as Problem);
                if (frm.ShowDialog() == DialogResult.Cancel)
                    continue;
                Problem newproblem = frm.InputProblem;
                row.Cells[1].Value = newproblem.Title;
                row.Cells[2].Value = newproblem.LtUrl;
                row.Cells[3].Value = newproblem.CsdnAddress;
                row.Cells[4].Value = newproblem.Content;
                row.Cells[5].Value = newproblem.Tags;
            }
            _problemController.UpdateProblems();
        }

    }
}
