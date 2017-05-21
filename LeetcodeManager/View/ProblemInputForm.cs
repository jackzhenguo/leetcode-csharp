using LeetcodeManager.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using LeetcodeManager.Lib;
using LeetcodeManager.Controller;

namespace LeetcodeManager.View
{
    public partial class ProblemInputForm : Form
    {
        private Problem _problem;
        private UltraCombo ultraCombo1;
        private readonly ProblemInputController _problemController;
        private readonly TagInputController _tagController;
        public ProblemInputForm()
        {
            InitializeComponent();
            _problemController = new ProblemInputController();
            _tagController = new TagInputController();
            _problem = new Problem();
            ultraCombo1 = new UltraCombo();
            ultraCombo1.Location = new Point(titleTxtbox.Location.X, 12);
            ultraCombo1.Size = new Size(titleTxtbox.Size.Width, 21);
            Controls.Add(ultraCombo1);
            ultraCombo1.DataSource = _tagController.TagsToTable();
            fillUltraCombo();
        }

        public ProblemInputForm(Problem problem)
            : this()
        {
            titleTxtbox.Text = problem.Title;
            LtCodeTxtbox.Text = problem.LtUrl;
            CsdnTxtbox.Text = problem.CsdnAddress;
            contentTxtbox.Text = problem.Content;
        }
        public Problem InputProblem
        {
            get
            {
                return _problem;
            }
        }
        //ok
        private void button1_Click(object sender, EventArgs e)
        {
            _problem.Title = titleTxtbox.Text;
            _problem.LtUrl = LtCodeTxtbox.Text;
            _problem.Content = contentTxtbox.Text;
            _problem.CsdnAddress = CsdnTxtbox.Text;
            if (SysHelper.CollectionNullOrEmpty<UltraGridRow>(this.ultraCombo1.CheckedRows))
            {
                MessageBox.Show("not select any tag! please create a new tag.");
                return;
            }
            foreach (UltraGridRow row in this.ultraCombo1.CheckedRows)
            {
                var tag = _tagController.GetATagByName(row.Cells["Name"].Value.ToString());
                if (_problem.Tags == null)
                    _problem.Tags = new List<Tag>();
                if (!_problem.Tags.Contains(tag))
                    _problem.Tags.Add(tag);
            }

            if (string.IsNullOrEmpty(_problem.Title))
            {
                SysHelper.ShowMessageWarning("Title cannot be empty!");
                return;
            }
            DialogResult = DialogResult.OK;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fillUltraCombo()
        {
            //Add an additional unbound column to WinCombo.
            //This will be used for the Selection of each Item
            UltraGridColumn c = this.ultraCombo1.DisplayLayout.Bands[0].Columns.Add();
            ultraCombo1.DisplayLayout.Bands[0].Override.ActiveRowAppearance.BackColor = Color.Orange;
            ultraCombo1.DisplayLayout.Bands[0].Override.BorderStyleRow = UIElementBorderStyle.Dashed;

            c.Key = "Selected";
            c.Header.Caption = string.Empty;

            //This allows end users to select / unselect ALL items
            c.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;

            c.DataType = typeof(bool);

            //Move the checkbox column to the first position.
            c.Header.VisiblePosition = 0;

            this.ultraCombo1.CheckedListSettings.CheckStateMember = "Selected";
            this.ultraCombo1.CheckedListSettings.EditorValueSource = Infragistics.Win.EditorWithComboValueSource.CheckedItems;
            // Set up the control to use a custom list delimiter
            this.ultraCombo1.CheckedListSettings.ListSeparator = " / ";
            // Set ItemCheckArea to Item, so that clicking directly on an item also checks the item
            this.ultraCombo1.CheckedListSettings.ItemCheckArea = Infragistics.Win.ItemCheckArea.Item;
            this.ultraCombo1.DisplayMember = "Name";
            this.ultraCombo1.ValueMember = "TagId";

        }

    }
}
