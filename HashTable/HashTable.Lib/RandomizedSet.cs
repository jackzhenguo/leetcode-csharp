/* ==============================================================================
 * 功能描述：IDG  
 * 创 建 者：gz
 * 创建日期：2017/5/10 12:41:14
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading;

namespace IDGSln
{

    /// <summary>
    /// IDG
    /// </summary>
    public class RandomizedSet
    {
        //insert remove getRandom
        private Dictionary<int, int> _dict;  //key: value, Value: index
        private List<int> _valList; //element of value list, for it can get the O(1) visit
        public RandomizedSet()
        {
            _dict = new Dictionary<int, int>();
            _valList = new List<int>();
        }

        public bool Insert(int val)
        {
            if (!_dict.ContainsKey(val))
            {
                _dict.Add(val, _valList.Count);
                _valList.Add(val);
                return true;
            }
            return false;
        }

        public bool Remove(int val)
        {
            if (!_dict.ContainsKey(val)) return false;
            int removeIndex = _dict[val]; //_dict.Values: element index collection

            swapToLast(removeIndex);

            _valList.Remove(val);
            _dict.Remove(val);
            return true;
        }

        //i-待移除元素的索引
        //将待移除元素移到_valList的末尾，修改原来末尾元素在字典中的键值
        private void swapToLast(int i)
        {
            int lastIndex = _valList.Count - 1;
            if (i > lastIndex) return;
            int lastVal = _valList[lastIndex];
            int tmpVal = _valList[i];
            _valList[i] = lastVal; // the key is to prove " i < lastIndex" !!!
            _valList[lastIndex] = tmpVal;
            //this is important, to update the last index value in dictionary
            _dict[lastVal] = i; 
        }

        public int GetRandom()
        {
            long tick = DateTime.Now.Ticks;
            Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
            int randnum = ran.Next(_valList.Count);
            if (_valList.Count == 0) return -1;
            Thread.Sleep(20);

            return _valList[randnum];
        }

    }

}
