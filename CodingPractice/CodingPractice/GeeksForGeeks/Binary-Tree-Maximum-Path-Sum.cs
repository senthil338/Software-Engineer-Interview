using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class Binary_Tree_Maximum_Path_Sum
    {
        int max_sum = int.MinValue;

        public int max_gain(TreeNode node)
        {
            if (node == null) return 0;

            // max sum on the left and right sub-trees of node
            int left_gain = Math.Max(max_gain(node.left), 0);
            int right_gain = Math.Max(max_gain(node.right), 0);

            // the price to start a new path where `node` is a highest node
            int price_newpath = node.val + left_gain + right_gain;

            // update max_sum if it's better to start a new path
            max_sum = Math.Max(max_sum, price_newpath);

            // for recursion :
            // return the max gain if continue the same path
            return node.val + Math.Max(left_gain, right_gain);
        }

        public int maxPathSum(TreeNode root)
        {
            max_gain(root);
            return max_sum;
        }
    }
}
