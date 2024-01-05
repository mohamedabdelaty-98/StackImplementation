using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation.StackUsingLinkedList
{
    internal class StackLinkedList<T>
    {
        Node<T> Top,Current;
        public StackLinkedList()
        {
            Top = Current = null;
        }
        private bool IsEmpty()=> Top==null;
        public void Push(T item)
        {
            Node<T> NewNode = new Node<T>();
            NewNode.Value = item;
            NewNode.Next= Top;
            Top = NewNode;
        }
        public T Pop()
        {
            if (!IsEmpty())
            {
                T Data = Top.Value;
                Current = Top;
                Top = Top.Next;
                Current = Current.Next = null;
                return Data;
            }
            else
                throw new Exception("Stack is Empty");
        }
        public T Peek()
        {
            if(!IsEmpty())
                return Top.Value;
            else
                throw new Exception("Stack is Empty");
        }
    }
}
