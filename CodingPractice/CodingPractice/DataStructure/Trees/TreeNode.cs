
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGraph
{
    public class TreeNode
    {
        public string Value { get; set; }
        public List<TreeNode> Neighbors { get; set; }

        public TreeNode(string s)
        {
            Value = s;
            Neighbors = new List<TreeNode>();
        }

        public void GenerateTree()
        {
            TreeNode abe = new TreeNode("Abe");
            TreeNode homer = new TreeNode("Homer")  ;
            TreeNode bart = new TreeNode("Bart");
            TreeNode lisa = new TreeNode("Lisa");
            TreeNode maggie = new TreeNode("Maggie");

            abe.Neighbors.Add(homer);
            homer.Neighbors.Add(bart);
            homer.Neighbors.Add(lisa);
            homer.Neighbors.Add(maggie);
        }
    }
}
