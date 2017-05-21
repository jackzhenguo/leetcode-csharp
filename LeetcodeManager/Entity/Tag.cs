using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace LeetcodeManager.Entity
{
    public class Tag
    {
        public int TagId { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }

        public virtual IList<Problem> Problems { get; set; }
    }
}
