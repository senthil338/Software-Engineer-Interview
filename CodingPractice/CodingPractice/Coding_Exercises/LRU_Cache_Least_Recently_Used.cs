using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Problems
{
    public class LRU_Cache_Least_Recently_Used
    {
        #region using Queue
        private int _capacity;
        public LRU_Cache_Least_Recently_Used(int capacity) {
            this._capacity = capacity;
        }
        Queue<int> queue = new Queue<int>();
        public int Get(int value) {
            int val = -1;
            if (queue.Contains(value))
            {
                val = queue.Dequeue();
                queue.Enqueue(val);
            }
            return val;
        }
        public void Set(int value) {

            if (queue.Contains(value))
            {
                int val = queue.Dequeue();
                queue.Enqueue(val);
            }
            else if(_capacity > queue.Count)
            {
                queue.Enqueue(value);
            }
            else{
            throw new Exception("There is no page to store value");
            }
        }
        #endregion

      


        }
    public class DNode
    {
        public int value;
        public int key;
        public DNode prev;
        public DNode next;
        public DNode(int key,int value)
        {
            this.value = value;
            this.key = key;
            prev = next = null;
        }

    }

    public class LRU_Cache_dLinkedList {
        int capacity = 0;
        Dictionary<int, DNode> map = new Dictionary<int, DNode>();
        DNode head;
        DNode end;

        public LRU_Cache_dLinkedList(int capacity) {
            this.capacity = capacity;
        }

        public void Get(int key) {
            if (map.ContainsKey(key)) {
                
            }
        }

        private void remove(DNode n) {
            if (n.prev != null)
            {
                n.prev.next = n.next;
            }
            else {
                head = n.next;
            }
            if (n.next != null)
            {
                n.next.prev = n.prev;
            }
            else
            {
                end = n.prev;
            }
        }

        public void setHead(DNode n)
        {
            n.next = head;
            n.prev = null;

            if (head != null)
                head.prev = n;

            head = n;

            if (end == null)
                end = head;
        }

        public void Set(int key, int value)
        {
            if (map.ContainsKey(key))
            {
                DNode old = map[key];
                old.value = value;
                remove(old);
                setHead(old);
            }
            else
            {
                DNode created = new DNode(key, value);
                if (map.Count >= capacity)
                {
                    map.Remove(end.key);
                    remove(end);
                    setHead(created);

                }
                else
                {
                    setHead(created);
                }

                map.Add(key, created);
            }
        }

        
    }
}
