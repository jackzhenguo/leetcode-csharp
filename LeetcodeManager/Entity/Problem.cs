using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeManager.Entity
{
    public class Problem
    {
        public int ProblemId { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }
        public string LtUrl { get; set; }
        public string CsdnAddress { get; set; }
        public string Content { get; set; }
        public virtual IList<Tag> Tags { get; set; }
    }
}
