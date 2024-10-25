using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterfaiseProject.Interfais;

namespace InterfaiseProject
{
    internal class RealisInterfais
    {
        public class NumberArray : IArrayManipulator
        {
            private readonly long[] _array;
            private int _count;

            public NumberArray(int size)
            {
                _array = new long[size];
                _count = 0;
            }

            public bool Find(long value) => Array.Exists(_array, v => v == value && Array.IndexOf(_array, v) < _count);

            public void Add(long value)
            {
                if (_count >= _array.Length) throw new InvalidOperationException("Array is full");
                _array[_count++] = value;
            }

            public bool Remove(long value)
            {
                int index = Array.IndexOf(_array, value, 0, _count);
                if (index == -1) return false;

                Array.Copy(_array, index + 1, _array, index, _count - index - 1);
                _count--;
                return true;
            }

            public void Show()
            {
                for (int i = 0; i < _count; i++)
                    Console.Write(_array[i] + " ");
                Console.WriteLine();
            }

            public int Size() => _count;

            public long FindMin()
            {
                if (_count == 0) throw new InvalidOperationException("Array is empty");
                long min = _array[0];
                for (int i = 1; i < _count; i++)
                    if (_array[i] < min) min = _array[i];
                return min;
            }

            public long FindMax()
            {
                if (_count == 0) throw new InvalidOperationException("Array is empty");
                long max = _array[0];
                for (int i = 1; i < _count; i++)
                    if (_array[i] > max) max = _array[i];
                return max;
            }
        }
    }
}
