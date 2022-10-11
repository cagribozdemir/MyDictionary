using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<TKey, TValue> // Generic Class
    {
        KeyValuePair<TKey, TValue>[] _array;
        KeyValuePair<TKey, TValue>[] _tempArray;
        public MyDictionary()
        {
            _array = new KeyValuePair<TKey, TValue>[0];
        }
        public void Add(TKey key, TValue value)
        {
            _tempArray = _array;
            _array = new KeyValuePair<TKey, TValue>[_array.Length+1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length-1]= new KeyValuePair<TKey, TValue>(key, value);
        }


        public int Count
        {
            get { return _array.Length; }
        }

    }
}
