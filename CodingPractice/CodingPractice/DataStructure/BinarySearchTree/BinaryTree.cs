using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.DataStructure.BinarySearchTree
{
    public class BinaryTree
    {
        public static void Main_1(String[] args)
        {
            BinaryTree bt = new BinaryTree();
            bt.findSum(32);
        }
        public class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node(int data)
            {
                this.Data = data;
                Left = Right = null;

            }
        }

       public Node root;

        public void Add()
        {
            Add(25);
            Add(20);
            Add(40);
            Add(15);
            Add(22);
            Add(35);
            Add(50);
            Add(10);
            Add(16);
            Add(21);
            Add(23);
            Add(30);
            Add(36);
            Add(45);
            Add(55);

        }

        public void Add_1()
        {
            Add(20);
            Add(8);
            Add(22);
            Add(4);
            Add(12);
            Add(10);
            Add(14);
        }
        #region is Tree is Binary Search Tree(BST) or not 
        /// <summary>
        /// root, int.MinValue, int.MaxValue
        /// </summary>
        /// <param name="root"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        private bool isBST(Node root, int min, int max)
        {
            if (root != null)
            {
                /* false if this node violates the min/max constraints */
                if (root.Data < min || root.Data > max)
                {
                    return false;
                }
                return (isBST(root.Left, min, root.Data - 1) && isBST(root.Right, root.Data + 1, max));
            }
            return true;
        }
        #endregion
        #region is Tree is Binary Search Tree(BST) or not usng inorder search 
        public void isBST_Inorder()
        {
            Add();
            Node prev = null;
            var result = isBST_Inorder(root, prev);
        }
        /// <summary>
        /// using in order traversal -> left , root, right
        /// Time Complexity: O(n)
        /// Is stack size is consider then space O(n)
        /// https://www.geeksforgeeks.org/a-program-to-check-if-a-binary-tree-is-bst-or-not/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        private bool isBST_Inorder(Node root, Node prev)
        {
            if (root != null)
            {
                if (!isBST_Inorder(root.Left, prev))
                {
                    return false;
                }
                if (prev != null && prev.Data <= root.Data)
                {
                    return false;
                }
                prev = root;
                return isBST_Inorder(root.Right, prev);
            }
            return true;

        }
        #endregion
        #region find pair of sum in tree, using stack
        public void findSum(int sum)
        {
            //Add();
            Add_1();
            Stack<Node> stack1 = new Stack<Node>();
            Stack<Node> stack2 = new Stack<Node>();
            Node curr1 = root;
            Node curr2 = root;

            while (stack1.Count != 0 || stack2.Count != 0 || curr1 != null || curr2 != null)
            {
                if (curr1 != null || curr2 != null)
                {
                    if (curr1 != null)
                    {
                        stack1.Push(curr1);
                        curr1 = curr1.Left;
                    }
                    if (curr2 != null)
                    {
                        stack2.Push(curr2);
                        curr2 = curr2.Right;
                    }
                }
                else
                {
                    int val1 = stack1.Peek().Data;
                    int val2 = stack2.Peek().Data;
                    int currentSum = val1 + val2;
                    if (val1 == val2)
                    {
                        break;
                    }
                    if (currentSum == sum)
                    {
                        Console.WriteLine("Val 1 " + val1 + " and Val 2 " + val2);
                    }
                    if (currentSum < sum)
                    {
                        curr1 = stack1.Pop();
                        curr1 = curr1.Right;
                    }
                    else if (currentSum > sum)
                    {
                        curr2 = stack2.Pop();
                        curr2 = curr2.Left;
                    }

                }

            }


        }
        #endregion
        #region Add BST
        /// <summary>
        /// Add data in the binary search tree non recurive
        /// </summary>
        /// <param name="data">param</param>
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                bool isAdded = false;
                do
                {
                    if (data < current.Data)
                    {
                        if (current.Left == null)
                        {
                            current.Left = newNode;
                            isAdded = true;
                        }
                        else
                        {
                            current = current.Left;
                        }
                    }
                    else
                    {
                        if (current.Right == null)
                        {
                            current.Right = newNode;
                            isAdded = true;
                        }
                        else
                        {
                            current = current.Right;
                        }
                    }
                } while (!isAdded);
            }
        }
        #endregion

        #region Add BST Recursive
        /// <summary>
        /// Add data in the bst recursively
        /// </summary>
        /// <param name="data"></param>
        public void AddRec(int data)
        {
            root = InsertData(root, data);
        }

        private Node InsertData(Node node, int data)
        {
            if (node == null)
            {
                node = new Node(data);
                return node;

            }
            else if (node.Data < data)
            {
                node.Right = InsertData(node.Right, data);
            }

            else if (node.Data > data)
            {
                node.Left = InsertData(node.Left, data);
            }
            return node;
        }
        #endregion

      
        #region find LCA
        public int FindLCA(int n1, int n2)
        {
            root = FindLCA(root, n1, n2);
            return root.Data;
        }
        /// <summary>
        /// Time O(log n) we are travelling down a path to the lca , 
        /// Recall that travelling a path to any one node takes O(log n)
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        private Node FindLCA(Node root, int n1, int n2)
        {
            if (root == null)
            {
                return null;
            }
            // If either n1 or n2 matches with root's key, report the presence
            // by setting v1 or v2 as true and return root (Note that if a key
            // is ancestor of other, then the ancestor key becomes LCA)
            if (root.Data > n1 && root.Data > n2)
            {
                return FindLCA(root.Left, n1, n2);
            }
            else if (root.Data < n1 && root.Data < n2)
            {
                return FindLCA(root.Right, n1, n2);
            }
            else
            {
                return root;
            }
        }
        #endregion

        #region print leaf node
        /// <summary>
        /// https://www.geeksforgeeks.org/print-leaf-nodes-left-right-binary-tree/
        /// </summary>
        public void PrintLeafNode()
        {
            printLeafNode(root);
        }
        private void printLeafNode(Node root)
        {
            if (root == null)
            {
                return;
            }
            // if node is leaf node, print its data     
            if (root.Left == null && root.Right == null)
            {
                Console.WriteLine(root.Data);
                return;
            }
            // if left child exists, check for leaf  
            // recursively 
            if (root.Left != null)
            {
                printLeafNode(root.Left);
            }
            // if right child exists, check for leaf  
            // recursively 
            if (root.Right != null)
            {
                printLeafNode(root.Right);
            }

        }
        #endregion

        #region print root node 
        public void PrintRootNode()
        {
            printRootNode(root);
        }


        // Traverses given tree in Inorder fashion and
        // prints all nodes that have both children as
        // non-empty.
        private void printRootNode(Node root)
        {
            if (root != null)
            {
                printRootNode(root.Left);
                if (root.Left != null && root.Right != null)
                {
                    Console.WriteLine(root.Data);
                }
                printRootNode(root.Right);
            }
        }
        #endregion

        #region Tree Travesal
        public void PreOrder()
        {
            preOrder(root);
        }
        public void InOrder()
        {
            preOrder(root);
        }
        public void PostOrder()
        {
            postOrder(root);
        }

        private void preOrder(Node root)
        {
            if (root != null)
            {


                Console.WriteLine(root.Data);
                preOrder(root.Left);
                preOrder(root.Right);
            }
        }
        private void inOrder(Node root)
        {
            if (root != null)
            {
                inOrder(root.Left);
                Console.WriteLine(root.Data);
                inOrder(root.Right);
            }

        }

        private void postOrder(Node root)
        {
            if (root != null)
            {
                postOrder(root.Left);
                postOrder(root.Right);
                Console.WriteLine(root.Data);
            }
        }
        #endregion

        #region Search
        public bool Search(int n)
        {
            return search(root, n);
        }
        private bool search(Node root, int n)
        {
            if (root == null)
            {
                return false;
            }
            if (root.Data == n)
            {
                return true;
            }
            else if (root.Data > n)
            {
                search(root.Left, n);
            }
            else if (root.Data < n)
            {
                search(root.Right, n);
            }
            return false;
        }
        #endregion

        #region Kth smallest 
        /// <summary>
        /// A simpler solution would be to do an inorder traversal and keep track of the element 
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public int KthSmallest(int position)
        {
            return kthSmallest(root, position);
        }
        private int kthSmallest(Node root, int position)
        {
            if (root == null)
            {
                return position;
            }
            position = kthSmallest(root.Left, position);
            position--;

            if (position == 0)
            {
                Console.WriteLine(root.Data);

            }
            position = kthSmallest(root.Right, position);
            return position;
        }
        #endregion

        #region print-left-view-binary-tree
        // recursive function to print left view  
        public static int max_level = 0;
        // A wrapper over leftViewUtil()  
        public void leftView()
        {
            leftViewUtil(root, 1);
        }
        private void leftViewUtil(Node node, int level)
        {
            // Base Case  
            if (node == null)
            {
                return;
            }

            // If this is the first node of its level  
            if (max_level < level)
            {
                Console.Write(" " + node.Data);
                max_level = level;
            }

            // Recur for left and right subtrees  
            leftViewUtil(node.Left, level + 1);
            leftViewUtil(node.Right, level + 1);
        }
        #endregion

        #region ZigZag Tree Traversal or Level order traversal in spiral form
        /// <summary>
        /// https://www.geeksforgeeks.org/zigzag-tree-traversal/
        /// https://www.geeksforgeeks.org/level-order-traversal-in-spiral-form/
        /// We can print spiral order traversal in O(n) time and O(n) extra space. 
        /// The idea is to use two stacks. We can use one stack for printing from left to right 
        /// and other stack for printing from right to left. In every iteration, 
        /// we have nodes of one level in one of the stacks. We print the nodes,
        /// and push nodes of next level in other stack.
        /// </summary>
        public virtual void printZigZagTraversal()
        {

            // if null then return  
            if (root == null)
            {
                return;
            }

            // declare two stacks  
            Stack<Node> currentLevel = new Stack<Node>();
            Stack<Node> nextLevel = new Stack<Node>();

            // push the root  
            currentLevel.Push(root);
            bool leftToRight = true;

            // check if stack is empty  
            while (currentLevel.Count > 0)
            {

                // pop out of stack  
                Node node = currentLevel.Pop();

                // print the data in it  
                Console.Write(node.Data + " ");

                // store data according to current  
                // order.  
                if (leftToRight)
                {
                    if (node.Left != null)
                    {
                        nextLevel.Push(node.Left);
                    }

                    if (node.Right != null)
                    {
                        nextLevel.Push(node.Right);
                    }
                }
                else
                {
                    if (node.Right != null)
                    {
                        nextLevel.Push(node.Right);
                    }

                    if (node.Left != null)
                    {
                        nextLevel.Push(node.Left);
                    }
                }

                if (currentLevel.Count == 0)
                {
                    leftToRight = !leftToRight;
                    Stack<Node> temp = currentLevel;
                    currentLevel = nextLevel;
                    nextLevel = temp;
                }
            }
        }
        #endregion
        #region Level order traversal recursive function
        /// <summary>
        /// /* Compute the "height" of a tree --  
        ///the number of nodes along the longest
        ///path from the root node down to the
        ///farthest leaf node.*/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int Height(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                /* compute height of each subtree */
                int lheight = Height(root.Left);
                int rheight = Height(root.Right);

                /* use the larger one */
                if (lheight > rheight)
                {
                    return (lheight + 1);
                }
                else
                {
                    return (rheight + 1);
                }
            }
        }
        /* Print nodes at the given level */
        public virtual void printGivenLevel(Node root,
                                            int level)
        {
            if (root == null)
            {
                return;
            }
            if (level == 1)
            {
                Console.Write(root.Data + " ");
            }
            else if (level > 1)
            {
                printGivenLevel(root.Left, level - 1);
                printGivenLevel(root.Right, level - 1);
            }
        }
        /* function to print level order  
         traversal of tree*/
        public virtual void printLevelOrder()
        {
            
            int h = Height(root);
            int i;
            for (i = 1; i <= h; i++)
            {
                printGivenLevel(root, i);
            }
        }
        #endregion

        #region Level Order using Queue
        /* Given a binary tree. Print  
         its nodes in level order using 
             array for implementing queue */
             /*
            1) Create an empty queue q
            2) temp_node = root "start from root"
            3) Loop while temp_node is not NULL
                a) print temp_node->data.
                 b) Enqueue temp_node’s children(first left then right children) to q
                 c) Dequeue a node from q and assign it’s value to temp_node
              */
        public void printLevelOrder_Queue()
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {

                /* poll() removes the present head. 
                For more information on poll() visit  
                http://www.tutorialspoint.com/java/util/linkedlist_poll.htm */
                Node tempNode = queue.Dequeue();
                Console.Write(tempNode.Data + " ");

                /*Enqueue left child */
                if (tempNode.Left != null)
                {
                    queue.Enqueue(tempNode.Left);
                }

                /*Enqueue right child */
                if (tempNode.Right != null)
                {
                    queue.Enqueue(tempNode.Right);
                }
            }
        }
        #endregion

        #region check tree is MinHeap or not
        /// <summary>
        /// https://www.geeksforgeeks.org/given-level-order-traversal-binary-tree-check-tree-min-heap/
        /// These algorithms run with worse case O(n) complexity
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public static bool isMinHeap(int[] level)
        {
            int n = level.Length - 1;

            // First non leaf node is at 
            // index (n/2-1). Check whether  
            // each parent is greater than child  
            for (int i = (n / 2 - 1); i >= 0; i--)
            {
                // Left child will be at index 2*i+1  
                // Right child will be at index 2*i+2  
                if (level[i] > level[2 * i + 1])
                {
                    return false;
                }

                if (2 * i + 2 < n)
                {
                    // If parent is greater than right child  
                    if (level[i] > level[2 * i + 2])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        #region print vertical order
        public static SortedDictionary<int, List<int>> ht = new SortedDictionary<int, List<int>>();
        public List<int> al;

        /// <summary>
        /// https://algorithms.tutorialhorizon.com/print-the-binary-tree-in-vertical-order-path/
        /// Its a tricky solution.
       /// Do the preordertraversal.
        ///Take a variable called level, when ever you go left, do level++ AND when ever you go right do level–.
        ///With step above we have separated out the levels vertically.
        ///Now you need to store the elements of each level, so create a TreeMap and
        ///the(key, value) pair will be(level, elements at that level).
        ///At the end iterate through the TreeMap and print the results.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="level"></param>
        public void vertical(Node root, int level)
        {
            if (root == null)
            {
                return;
            }
            if (ht.ContainsKey(level))
            {
                var x = ht[level];
                
                x.Add(root.Data);
                ht[level] = x;
            }
            else
            {
                al = new List<int>();
                al.Add(root.Data);
                ht[level] = al;
            }
            vertical(root.Left, level - 1);
            vertical(root.Right, level + 1);
        }

        public void printResult(SortedDictionary<int, List<int>> ht)
        {
           
            foreach(KeyValuePair< int, List<int>> key in ht)
            {
                Console.WriteLine(key.Value);
                //value is a list and we need to iterate 
                
            }
        }
        #endregion
        #region Flatten a binary tree into linked list
        // Function to convert binary tree into 
        // linked list by altering the right node 
        // and making left node point to null and call inordder to print the value
        /// <summary>
        /// https://www.geeksforgeeks.org/flatten-a-binary-tree-into-linked-list-set-2/
        /// Time Complexity: O(N)
        ///Auxiliary Space: O(Log N)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        static Node solution(Node A)
        {

            // Declare a stack 
            Stack<Node> st = new Stack<Node>();
            Node ans = A;

            // Iterate till the stack is not empty 
            // and till root is Null 
            while (A != null || st.Count != 0)
            {

                // Check for null 
                if (A.Right != null)
                {
                    st.Push(A.Right);
                }

                // Make the Right Left and 
                // left null 
                A.Right = A.Left;
                A.Left = null;

                // Check for null 
                if (A.Right == null && st.Count != 0)
                {
                    A.Right = st.Peek();
                    st.Pop();
                }

                // Iterate 
                A = A.Right;
            }
            return ans;
        }
        #endregion
        #region Convert Binary tree to Doubly linked list
        // A simple recursive function to  
        // convert a given Binary tree to  
        // Doubly Linked List  
        //public virtual void BToDLL(Node root)
        //{
        //    // Base cases  
        //    if (root == null)
        //    {
        //        return;
        //    }

        //    // Recursively convert right subtree  
        //    BToDLL(root.right);

        //    // insert root into DLL  
        //    root.right = head;

        //    // Change left pointer of previous head  
        //    if (head != null)
        //    {
        //        (head).left = root;
        //    }

        //    // Change head of Doubly linked list  
        //    head = root;

        //    // Recursively convert left subtree  
        //    BToDLL(root.left);
        //}
        #endregion

    }
}

