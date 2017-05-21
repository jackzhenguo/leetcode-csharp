using LeetcodeManager.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeManager.DAL
{
    public class BaseDAL
    {
        protected static MyDb _db;
        protected BaseDAL()
        {
            _db = _db ?? new MyDb();
        }
    }
}
