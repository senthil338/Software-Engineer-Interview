using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class Subtree_of_another_tree
    {
        /*
         Instead of creating an inorder traversal, we can treat every node of the given tree tt as the root, treat it as a subtree and compare the 
         corresponding subtree with the given subtree ss for equality. For checking the equality, we can compare the all the nodes of the two subtrees.
         For doing this, we make use a function traverse(s,t) which traverses over the given tree ss and treats every node as the root of the 
         subtree currently being considered. It also checks the two subtrees currently being considered for their equality. 
         In order to check the equality of the two subtrees, we make use of equals(x,y) function, which takes xx and yy, which are the roots of
         the two subtrees to be compared as the inputs and returns True or False
         depending on whether the two are equal or not. It compares all the nodes of the two subtrees for equality. 
         Time complexity : O(m∗n). In worst case(skewed tree) traverse function takes O(m*n)O(m∗n) time.

            Space complexity : O(n). The depth of the recursion tree can go upto nn. nn refers to the number of nodes in ss.
             */
        public bool isSubtree(TreeNode s, TreeNode t)
        {
            return traverse(s, t);
        }
        public bool equals(TreeNode x, TreeNode y)
        {
            if (x == null && y == null)
                return true;
            if (x == null || y == null)
                return false;
            return x.val == y.val && equals(x.left, y.left) && equals(x.right, y.right);
        }
        public bool traverse(TreeNode s, TreeNode t)
        {
            return s != null && (equals(s, t) || traverse(s.left, t) || traverse(s.right, t));
        }
    }
}
