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
    public class ProblemDAL:BaseDAL
    {
        public IEnumerable<Tag> QueryAllTags()
        {
            DbSet<Tag> tags = _db.Tags;
            if (tags == null) return new List<Tag>();
            return tags.AsEnumerable<Tag>();
        }

        public bool IsNew(Problem problem)
        {
            return problem.ProblemId == 0;
        }
        public Problem CreateAProblem(Problem problem)
        {
            if (!IsNew(problem)) return problem;
            _db.Problems.Add(problem);
            _db.SaveChanges();
            var problems = _db.Problems.OrderByDescending(r => r.ProblemId).AsEnumerable<Problem>();
            if (!SysHelper.CollectionNullOrEmpty<Problem>(problems))
                return problems.First();
            return new Problem();
        }
        public void UpdateProblems()
        {
            _db.SaveChanges();
        }

        public void DeleteAProblem(Problem problem)
        {
            _db.Problems.Remove(problem);
            _db.SaveChanges();
        }

        public void DeleteProblems(IList<Problem> problems)
        {
            int cnt = problems.Count();
            for(int i=0;i<cnt;i++)
            {
                _db.Problems.Remove(problems[i]);
            }
            _db.SaveChanges();
        }

    }
}
