using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeetcodeManager.Lib
{
    public class SysHelper
    {
        public static void ShowMessageOK(string msg)
        {
            MessageBox.Show(msg, "LeetCode Manager", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public static void ShowMessageWarning(string msg)
        {
            MessageBox.Show(msg, "LeetCode Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowMessageYesOrNo(string msg)
        {
            return MessageBox.Show(msg, "LeetCode Manager", MessageBoxButtons.YesNo);
        }

        public static bool CollectionNullOrEmpty<T>(IEnumerable<T> enumerable) 
        {
            return enumerable == null || enumerable.Count() == 0;
        }


    }
}
