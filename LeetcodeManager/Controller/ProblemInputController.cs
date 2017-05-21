using LeetcodeManager.Controller;
using LeetcodeManager.DAL;
using LeetcodeManager.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeManager.Controller
{
    public class ProblemInputController
    {
        private readonly TagDAL _tagDal = new TagDAL();
        private readonly ProblemDAL _problemDal = new ProblemDAL();

        public bool IsNew(Problem problem)
        {
            if (problem == null) return true;
            return _problemDal.IsNew(problem);
        }
        public Problem SaveProblem(Problem problem)
        {
            return _problemDal.CreateAProblem(problem);
        }
        public void UpdateProblems()
        {
            _problemDal.UpdateProblems();
        }
        public void DeleteProblem(Problem problem)
        {
            _problemDal.DeleteAProblem(problem);
        }
        public void DeleteProblems(IList<Problem> problems)
        {
            _problemDal.DeleteProblems(problems);
        }
    }
}
