using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class FlatternBST
    {
        /// <summary>
        /// https://leetcode.com/explore/interview/card/facebook/52/trees-and-graphs/322/discuss/425617/Java-beat-100-Space-and-Time
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private TreeNode flattenInternal(TreeNode node)
        {
            if (node == null || (node.left == null && node.right == null)) return node;

            TreeNode leftRightMost = flattenInternal(node.left);
            TreeNode rightRightMost = flattenInternal(node.right);

            if (leftRightMost != null)
            {
                leftRightMost.right = node.right;
                node.right = node.left;
                node.left = null;
            }

            return rightRightMost == null ? leftRightMost : rightRightMost;
        }

        public void flatten(TreeNode root)
        {
            flattenInternal(root);
        }
    }
}
