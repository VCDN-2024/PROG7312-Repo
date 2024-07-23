using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSpaceVC
{
    using System;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    public class CustomArray<T>
    {
        private T[] innerArray;
        private int count;

        public CustomArray(int size)
        {
            innerArray = new T[size];
            count = 0;
        }

        public int Count => count;

        public void Add(T item)
        {
            if (count >= innerArray.Length)
            {
                throw new InvalidOperationException("Array is full");
            }
            innerArray[count] = item;
            count++;
        }

        public void AddResize(T item)
        {
            if (count >= innerArray.Length)
            {
                Resize();
            }
            innerArray[count] = item;
            count++;
        }

        private void Resize()
        {
            T[] newArray = new T[innerArray.Length + 1];
            Array.Copy(innerArray, newArray, innerArray.Length);
            innerArray = newArray;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            return innerArray[index];
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            for (int i = index; i < count - 1; i++)
            {
                innerArray[i] = innerArray[i + 1];
            }
            innerArray[count - 1] = default(T);
            count--;
        }

        public int Search(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (innerArray[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(innerArray[i]);
            }
            Console.WriteLine("Count: " + count);
        }
    }

}
