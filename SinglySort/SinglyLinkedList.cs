using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglySort
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
        }

        public Node()
        {

        }

        public static bool operator >(Node<T> f, Node<T> s)
        {
            if (Comparer<T>.Default.Compare(f.Data, s.Data) < 0)
                return false;
            else
                return true;
        }
        public static bool operator <(Node<T> f, Node<T> s)
        {
            if (Comparer<T>.Default.Compare(f.Data, s.Data) < 0)
                return true;
            else
                return false;
        }
        public static bool operator <=(Node<T> f, Node<T> s)
        {
            if (Comparer<T>.Default.Compare(f.Data, s.Data) <= 0)
                return true;
            else
                return false;
        }
        public static bool operator >=(Node<T> f, Node<T> s)
        {
            if (Comparer<T>.Default.Compare(f.Data, s.Data) >= 0)
                return true;
            else
                return false;
        }
    }

    public class List<T>
    {    
        private Node<T> headNode;
        private Node<T> tailNode;

        public int Count { get; private set; }

        public bool IsEmpty { get { return Count == 0; } }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public T this[int index]
        {
            get
            {
                Node<T> tempNode = new Node<T>();

                if (index < Count)
                {
                    tempNode = headNode;
                    for (int i = 0; i < index; i++)
                        tempNode = tempNode.Next;
                }

                return tempNode.Data;
            }
            set
            {
                if (index < Count)
                {
                    Node<T> newValue = headNode;

                    for (int i = 0; i < index; i++)
                        newValue = newValue.Next;

                    newValue.Data = value;
                }
            }
        }
        public Node<T> this[int index, char l]
        {
            get
            {
                Node<T> tempNode = new Node<T>();

                if (index < Count)
                {
                    tempNode = headNode;
                    for (int i = 0; i < index; i++)
                        tempNode = tempNode.Next;
                }

                return tempNode;
            }
        }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (headNode == null)
                headNode = node;
            else
                tailNode.Next = node;

            tailNode = node;
            Count++;
        }

        public void RemoveAt(int i)
        {
            if (i == 0)
            {
                headNode = headNode.Next;
            }
            else if (i == Count - 1)
            {
                this[i - 1, 's'].Next = this[i, 's'];
                tailNode = this[i - 1, 's'];
                tailNode.Next = null;
            }
            else
            {
                Node<T> temp1 = this[i - 1, 's'];
                Node<T> temp2 = temp1.Next;
                temp1.Next = temp2.Next;
            }
            Count--;
        }

        public bool Remove(T data)
        {
            Node<T> current = headNode;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                            tailNode = previous;
                    }
                    else
                    {
                        headNode = headNode.Next;

                        if (headNode == null)
                            tailNode = null;
                    }
                    Count--;

                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

        public void Insert(int i, T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (i == 0)
            {
                Node<T> previous;
                previous = headNode;
                headNode = newNode;
                headNode.Next = previous;
                Count++;
            }
            else
            {
                if (i == Count - 1)
                {
                    Add(value);
                }
                else
                {
                    this[i - 1, 's'].Next = newNode;
                    this[i - 1] = newNode.Data;
                    newNode.Next = this[i + 1, 's'];
                    Count++;
                }
            }
        }

        public void Clear()
        {
            headNode = null;
            tailNode = null;
            Count = 0;
        }
    }
}
