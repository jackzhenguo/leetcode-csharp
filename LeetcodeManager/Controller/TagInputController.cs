using LeetcodeManager.DAL;
using LeetcodeManager.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeManager.Controller
{
    public class TagInputController
    {
        private readonly TagDAL _tagDAL = new TagDAL();
        public DataTable TagsToTable()
        {
            var tagTable = new DataTable();
            tagTable.Columns.AddRange(new DataColumn[]{
                    new DataColumn("TagId",typeof(int)),
                    new DataColumn("Name",typeof(string))
                });
            IEnumerable<Tag> tags = _tagDAL.QueryAllTags();
            foreach (var tag in tags)
            {
                var row = tagTable.NewRow();
                row["TagId"] = tag.TagId;
                row["Name"] = tag.Name;
                tagTable.Rows.Add(row);
            }
            return tagTable;
        }
        public Tag GetATagByName(string name)
        {
            return _tagDAL.QueryTagByName(name);
        }
        public Tag GetATagById(int id)
        {
            return _tagDAL.QueryTagById(id);
        }
        public IEnumerable<Tag> GetAllTags()
        {
            return _tagDAL.QueryAllTags();
        }
        public bool IsNew(Tag tag)
        {
            if (tag == null) return true;
            return _tagDAL.IsNew(tag);
        }

        public Tag SaveTagToDb(Tag tag)
        {
            return _tagDAL.CreateATag(tag);
        }

        public void DeleteTag(Tag tag)
        {
            _tagDAL.DeleteATag(tag);
        }

        public void UpdateTagName(Tag tag)
        {
            _tagDAL.UpdateATagName(tag);
        }
    }
}
