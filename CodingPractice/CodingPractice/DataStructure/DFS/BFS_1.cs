using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.DataStructure.DFS
{
    class BFS_1
    {
        static void Main_2(string[] args)
        {
            Node topNode = new Node() { Value = 1 };
            topNode.Neighbours.Add(new Node()
            {
                Value = 2,
                Neighbours = new List<Node> { new Node() { Value = 5,
                    Neighbours = new List< Node > { new Node() { Value = 9 } } }
                }
            });
            topNode.Neighbours.Add(new Node()
            {
                Value = 3,
                Neighbours = new List<Node> { new Node() { Value = 6,
                    Neighbours = new List<Node>() { new Node() { Value = 10 } } }, new Node() { Value = 7 } }
            });
            topNode.Neighbours.Add(new Node() { Value = 4,
                Neighbours = new List<Node>() { new Node() { Value = 8 } } });


            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(topNode);

            while (queue.Count > 0)
            {
                var element = queue.Dequeue();
                if (element.Neighbours.Count > 0)
                {
                    Console.WriteLine(element.Value);
                    foreach (var item in element.Neighbours)
                    {
                        queue.Enqueue(item);
                    }
                }
                else
                    Console.WriteLine(element.Value);
            }

            Console.Read();
        }

        public class Node
        {
            public Node()
            {
                Neighbours = new List<Node>();
            }

            public int Value { get; set; }
            public IList<Node> Neighbours { get; set; }
        }
    }
}
