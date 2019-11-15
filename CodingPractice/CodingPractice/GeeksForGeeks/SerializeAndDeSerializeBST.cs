using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingPractice.GeeksForGeeks
{
    class SerializeAndDeSerializeBST
    {
        #region Serialize
        // Encodes a tree to a single string.
        public String serialize(TreeNode root)
        {
            return rserialize(root, "");
        }

        public String rserialize(TreeNode root, String str)
        {
            // Recursive serialization.
            if (root == null)
            {
                str += "null,";
            }
            else
            {
                str += root.val + ",";
                str = rserialize(root.left, str);
                str = rserialize(root.right, str);
            }
            return str;
        }
        #endregion
        #region Deserialize
        public TreeNode rdeserialize(List<String> l)
        {
            // Recursive deserialization.
            if (l[0].Equals("null"))
            {
                l.RemoveAt(0);
                return null;
            }

            TreeNode root = new TreeNode(Convert.ToInt32(l[0]));
            l.RemoveAt(0);
            root.left = rdeserialize(l);
            root.right = rdeserialize(l);
            return root;
        }
        // Decodes your encoded data to tree.
        public TreeNode deserialize(String data)
        {
            String[] data_array = data.Split(",");
            List<String> data_list = new List<String>(data_array.OfType<string>()); 
            return rdeserialize(data_list);
        }
        #endregion

    }
}
