using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// Custom collection that represent reversed List
    /// </summary>
    /// <typeparam name="T">Type of element in the ReversedList</typeparam>

    public class ReversedList<T>
    {
        private T[] data;
        private int size;
        private int capacity = 2;
        
        public ReversedList()
        {
            this.data = new T[capacity];
        }
        public ReversedList(params T[] data)
        {
            this.data = data;
            this.size = data.Length;
            if (this.capacity < data.Length)
            {
                setCapacity(data);

            }
        }
        public void Add(T item)
        {
            if(this.size + 1 == this.capacity)
            {
                Array.Resize(ref this.data, this.capacity * 2);
                this.capacity *= 2;
            }
           
            this.data[size] = item;
            this.size++;

        }
        public int Capacity()
        {
            return this.capacity;

        }
        public int Count()
        {
            return this.size;
        }

        public T this[int index] => ReverseData(this.data)[index];
        private T[] ReverseData( T[] data)
        {
            int count = 0;
            var newArr = new T[data.Length];
             Array.Copy(data,newArr,data.Length);
            for (int i = data.Length - 1; i >= 0; i--)
            {
                newArr[count] = data[i];
                count++;
            }
            return newArr;
        }
        private void setCapacity(T[] data)
        {
            while (this.capacity < data.Length)
            {
                this.capacity *= 2;
            }
        }
        public void RemoveAt(int index)
        {
           var dataT = ReverseData(this.data);
            for (int a = index; a < this.dataT.Length - 1; a++)
            {
                // moving elements downwards, to fill the gap at [index]
                this.dataT[a] = this.dataT[a + 1];
            }
            // finally, let's decrement Array's size by one
           // Array.Resize(ref data, data.Length - 1);
        }
    }
}
