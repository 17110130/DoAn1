using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan1
{
    public class LinkedListHD<T>
    {
        public class Node
        {
            public T data;
            public Node pNext;
        }
        public Node pHead;
        public Node pTail;
        public int count;

        public LinkedListHD()
        {
            pHead = null;
            pTail = null;
            count = 0;
        }

        //public override string ToString()
        //{
        //    string text = "";
        //    while(pHead.data !=  null)
        //    {
        //        text += pHead.data.ToString() + "\n";
        //    }
        //    return text;
        //}

        Node CreateNode(T import)
        {
            Node p = new Node();
            if ( p != null )
            {
                p.data = import;
                p.pNext = null;
            }
            return p;
        }

        public void Add (T info)
        {
            Node p = CreateNode(info);
            if ( pHead == null )
            {
                pHead = p;
                pTail = p;
            }
            else
            {
                pTail.pNext = p;
                pTail = p;
                pTail.pNext = null;
            }
            count++;
        }

        public void Remove(Node pSearch)
        {
            Node pDelete = pHead;
            Node pPre = null;

            while (pDelete != null)
            {
                if (pDelete == pSearch)
                    break;
                pPre = pDelete;
                pDelete = pDelete.pNext;
            }
            if (pDelete == pHead)
            {
                pHead = pHead.pNext;
                pDelete.pNext = null;
                pDelete = null;
            }
            else if (pDelete.pNext == null)
            {
                pTail = pPre;
                pPre.pNext = null;
                pDelete = null;
            }
            else
            {
                pPre.pNext = pDelete.pNext;
                pDelete.pNext = null;
                pDelete = null;
            }

            count--;
        }

    }
}
