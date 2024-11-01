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
            private OrderedArray _orderedArray;
            private readonly long[] _array;
            private int _count;

            public NumberArray(int size)
            {
                _orderedArray = new OrderedArray(size);
                _array = new long[size];
                _count = 0;
            }


            public bool Find(long value) => _orderedArray.Contains(value);

            public void Add(long value)
            {
                if (!_orderedArray.Insert(value))
                {
                    return;
                }
            }

            public bool Remove(long value)
            {
                bool removed = _orderedArray.Remove(value);
                if (removed) _count--;
                return removed;
            }

            public void Show()
            {
                for (int i = 0; i < _count; i++)
                    Console.Write(_array[i] + " ");
                Console.WriteLine();
            }

            public int Size() => _count;

            public long FindMin() => _orderedArray.FindMin();

            public long FindMax() => _orderedArray.FindMax();
        }
        //Работу выполнил Рязанов А.В. ПИНб-21
    }
}
