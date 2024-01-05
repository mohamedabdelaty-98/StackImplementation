using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    internal class Stackimplementation<T>
    {
        int top;
        int size;
        T[] arr;
        public Stackimplementation(int size=5)
        {
            top = -1;
            this.size = size<=0?10:size;
            arr = new T[size];
        }
        public bool IsEmpty()
        {
            return top<0;
        }
        private bool IsFull()
        {
            return top >= size - 1;
        }
        private void Extend(int size)
        {
            T[]newarr= new T[size];
            Array.Copy(arr, newarr, arr.Length);
            arr = newarr;
        }
        public void Push(T Element)
        {
            if (!IsFull())
                arr[++top] = Element;
            else
            {
                //throw new Exception("Stack is full");
                Extend(size*2);
                arr[++top]=Element;
            }

        }
        public T Pop()
        {
            if (!IsEmpty())
                return arr[top--];
            else
                 throw new Exception("Stack is empty");
        }
        public T Peek()
        {

            if (!IsEmpty())
                return arr[top];
            else
                throw new Exception("Stack is empty");
        }
    }
}
