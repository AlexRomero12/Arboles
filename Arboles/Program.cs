namespace Arboles
{
    public class TreeNode
    {
        public class Node
        {
            public int Weight { get; set; }
            public List<Node> Children { get; set; }

            public Node(int weight)
            {
                Weight = weight;
                Children = new List<Node>();
            }
        }

        public int GetTreeWeight(Node root)
        {
            int weight = root.Weight;
            foreach (Node child in root.Children)
            {
                weight += GetTreeWeight(child);
            }
            return weight;
        }

        public int GetTreeHeight(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            int maxHeight = 0;
            foreach (Node child in root.Children)
            {
                int childHeight = GetTreeHeight(child);
                if (childHeight > maxHeight)
                {
                    maxHeight = childHeight;
                }
            }
            return maxHeight + 1;
        }

        public int GetNumberOfNodes(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            int count = 1;
            foreach (Node child in root.Children)
            {
                count += GetNumberOfNodes(child);
            }
            return count;
        }

        public double GetAverageWeight(Node root)
        {
            int totalWeight = GetTreeWeight(root);
            int numberOfNodes = GetNumberOfNodes(root);
            return (double)totalWeight / numberOfNodes;
        }

        public static void Main()
        {
            var treeNode = new TreeNode();
            Node root = new Node(5);
            Node child1 = new Node(3);
            Node child2 = new Node(2);

            root.Children.Add(child1);
            root.Children.Add(child2);

            int treeWeight = treeNode.GetTreeWeight(root);
            int treeHeight = treeNode.GetTreeHeight(root);
            double averageWeight = treeNode.GetAverageWeight(root);

            Console.WriteLine("El peso total del árbol es: " + treeWeight);
            Console.WriteLine("La altura del árbol es: " + treeHeight);
            Console.WriteLine("El peso promedio del árbol es: " + averageWeight);
        }
    }
}