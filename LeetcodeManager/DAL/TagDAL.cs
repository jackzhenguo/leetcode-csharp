using LeetcodeManager.Entity;
using LeetcodeManager.Lib;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeManager.DAL
{
    public class TagDAL:BaseDAL
    {
        public IEnumerable<Tag> QueryAllTags()
        {
            DbSet<Tag> tags = _db.Tags;
            if (tags == null) return new List<Tag>();
            return tags.AsEnumerable<Tag>();
        }
        public Tag QueryTagByName(string name)
        {
            DbSet<Tag> tags = _db.Tags;
            if (tags == null) return new Tag();
            return tags.FirstOrDefault(r => r.Name == name);
        }

        public Tag QueryTagById(int id)
        {
            DbSet<Tag> tags = _db.Tags;
            if (tags == null) return new Tag();
            return tags.FirstOrDefault(r => r.TagId == id);
        }

        public bool IsNew(Tag tag)
        {
            return tag.TagId == 0;
        }

        public Tag CreateATag(Tag tag)
        {
            if (!IsNew(tag)) return tag;
            _db.Tags.Add(tag);
            _db.SaveChanges();
            var tags = _db.Tags.OrderByDescending(r => r.TagId).AsEnumerable<Tag>();
            if (!SysHelper.CollectionNullOrEmpty<Tag>(tags))
                return tags.First();
            return new Tag();
        }

        public void DeleteATag(Tag tag)
        {
            _db.Tags.Remove(tag);
            _db.SaveChanges();
        }

        public void UpdateATagName(Tag tag)
        {
            Tag tagdb = _db.Tags.FirstOrDefault(r => r.TagId == tag.TagId);
            if (tag != null)
                tagdb.Name = tag.Name;
            _db.SaveChanges();
        }
    }
}
