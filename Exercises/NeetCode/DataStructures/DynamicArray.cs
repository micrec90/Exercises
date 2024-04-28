using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.DataStructures
{
    public class DynamicArray
    {
        private int[] _array;
        private int _capacity;
        private int _length;

        public DynamicArray(int capacity)
        {
            _capacity = capacity;
            _length = 0;
            _array = new int[capacity];
        }

        public int Get(int i)
        {
            return _array[i];
        }

        public void Set(int i, int n)
        {
            _array[i] = n;
        }

        public void PushBack(int n)
        {
            if (_length == _capacity)
                Resize();
            _array[_length] = n;
            _length++;
        }

        public int PopBack()
        {
            _length--;
            return _array[_length];
        }

        private void Resize()
        {
            _capacity *= 2;
            int[] newArray = new int[_capacity];
            for (int i = 0; i < _array.Length; i++)
                newArray[i] = _array[i];
            _array = newArray;
        }

        public int GetSize()
        {
            return _length;
        }

        public int GetCapacity()
        {
            return _capacity;
        }
    }
}
