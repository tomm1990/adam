using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bagrut2017
{
    class list 
    {
        private Node<int> head;
        private int min;
        private int max;
        private Node<int> nodeBeforeMax;
        public list()
        {

        }
        public void insert(int x)
        {
            Node<int> n = new Node<int>(x);
            Node<int> node = head;
            this.min = head.GetInfo();
            this.max = head.GetInfo();
            while (node!=null)
            {
                if (node.GetInfo()<min)
                {
                    min = node.GetInfo();
                }
                if (node.GetInfo()>max)
                {
                    max = node.GetInfo();
                }
                if (node.GetNext()==null)
                {
                    node.SetNext(n);
                }
                node = node.GetNext();
            }
            node = head;
            if (this.head.GetInfo()==this.max)
            {
                this.nodeBeforeMax = this.head;
            }
            else
            {
                while (node != null)
                {
                    if (node.GetNext().GetInfo() == max)
                    {
                        this.nodeBeforeMax = node;
                    }
                    node = node.GetNext();
                }
            }
        }
        public bool Exist(int x)
        {
            Node<int> node = head;
            while (node!=null)
            {
                if (x==node.GetInfo())
                {
                    return true;
                }
            }
            return false;
        }
        public int ShowMin()
        {
            if (head==null)
            {
                return -1;
            }
            return this.min;
        }
        public int GetMax()
        {
            if (head==null)
            {
                return -1;
            }
            if (this.nodeBeforeMax == head)
            {
                head = null;
                return this.max;
            }
            this.nodeBeforeMax.SetNext(this.nodeBeforeMax.GetNext().GetNext());
            return this.max;
        }
    }
}
