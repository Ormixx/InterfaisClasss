using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaiseProject
{
    internal class Interfais
    {
        public interface IArrayManipulator
        {
            bool Find(long searchValue);
            void Add(long value);
            bool Remove(long value);
            void Show();
            int Size();
            long FindMin();
            long FindMax();
        }
    }
}
