using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaiseProject
{
    public class OrderedArray
    {
        private long[] array;
        private int _count;

        public OrderedArray(int size)
        {
            array = new long[size];
            _count = 0;
        }

        public bool Contains(long searchValue)
        {
            int lowerBound = 0;
            int upperBound = _count - 1;

            while (lowerBound <= upperBound)
            {
                int currentIndex = (lowerBound + upperBound) / 2;
                if (array[currentIndex] == searchValue)
                    return true;
                else if (array[currentIndex] < searchValue)
                    lowerBound = currentIndex + 1;
                else
                    upperBound = currentIndex - 1;
            }
            return false;
        }

        public bool Insert(long value)
        {
            int i;
            for (i = 0; i < _count; i++)
            {
                if (array[i] == value)
                    return false;
                else if (array[i] > value)
                    break;
            }

            for (int j = _count; j > i; j--)
            {
                array[j] = array[j - 1];
            }
            array[i] = value;
            _count++;
            return true;
        }

        public bool Remove(long value)
        {
            int index = Array.BinarySearch(array, 0, _count, value);
            if (index < 0) return false;

            for (int j = index; j < _count - 1; j++)
            {
                array[j] = array[j + 1];
            }
            _count--;
            return true;
        }

        public long FindMin()
        {
            if (_count == 0) throw new InvalidOperationException("Array is empty");
            return array[0];
        }

        public long FindMax()
        {
            if (_count == 0) throw new InvalidOperationException("Array is empty");
            return array[_count - 1];
        }


    }
}
