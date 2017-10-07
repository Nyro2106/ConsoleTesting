using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    class TrashContainer<T>
    {
        T[] trash;
        int index;

        public TrashContainer(int size)
        {
            this.trash = new T[size];
        }

        public void Push(T item)
        {
            this.trash[index] = item;
            this.index++;
        }

        public T Pop()
        {
            this.index--;
            return this.trash[this.index];
        }
    }
}
