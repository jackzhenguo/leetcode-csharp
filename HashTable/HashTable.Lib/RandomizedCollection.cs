/* ==============================================================================
 * 功能描述：IDG  
 * 创 建 者：gz
 * 创建日期：2017/5/11 
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading;

//Design a data structure that supports all following operations in average O(1) time.

//Note: Duplicate elements are allowed. insert(val): Inserts an item val 
//to the collection. remove(val): Removes an item val from the 
//collection if present. getRandom: Returns a random element from 
//current collection of elements. The probability of each element being 
//returned is linearly related to the number of same value the 
//collection contains.
//Example:

//// Init an empty collection.
//RandomizedCollection collection = new RandomizedCollection();

//// Inserts 1 to the collection. Returns true as the collection did not contain 1.
//collection.insert(1);

//// Inserts another 1 to the collection. Returns false as the collection contained 1. Collection now contains [1,1].
//collection.insert(1);

//// Inserts 2 to the collection, returns true. Collection now contains [1,1,2].
//collection.insert(2);

//// getRandom should return 1 with the probability 2/3, and returns 2 with the probability 1/3.
//collection.getRandom();

//// Removes 1 from the collection, returns true. Collection now contains [1,2].
//collection.remove(1);

//// getRandom should return 1 and 2 both equally likely.
//collection.getRandom();
namespace IDGSln
{

    /// <summary>
    /// IDG
    /// </summary>
    public class RandomizedCollection
    {
        //insert remove getRandom
        private Dictionary<int, List<int>> _dict;  //key: value, Value: index collection
        private List<int> _valList; //element of value list, for it can get the O(1) visit
        public RandomizedCollection()
        {
            _dict = new Dictionary<int, List<int>>();
            _valList = new List<int>();
        }

        public bool Insert(int val)
        {
            if (!_dict.ContainsKey(val))
            {
                _dict.Add(val, new List<int> { _valList.Count });
                _valList.Add(val);
                return true;
            }
            _dict[val].Add(_valList.Count);
            _valList.Add(val);
            return false;
        }

        public bool Remove(int val)
        {
            if (!_dict.ContainsKey(val)) return false;
            List<int> removeIndexCollection = _dict[val]; //_dict.Values: element index collection

            swapToLast(removeIndexCollection[removeIndexCollection.Count-1]);            
            _valList.Remove(val);
            if (removeIndexCollection.Count == 1)
                _dict.Remove(val);
            else _dict[val].Remove(val);
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
            if(i!=lastIndex) //i 不是末尾元素
               _dict[lastVal].Add(i);
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
