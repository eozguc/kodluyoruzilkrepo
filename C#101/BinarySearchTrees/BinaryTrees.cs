namespace BinarySearchTrees;

public class BinaryTrees
{
    static Queue<Node> nodeQueue = new Queue<Node>();
    static void levelOrder(Node root){
        //Write your code here
        
        nodeQueue.Enqueue(root);
        while (nodeQueue.Count > 0)
        {
            var n = nodeQueue.Dequeue();
            Console.Write(n.data + " ");
            if (n.left != null)
            {
                nodeQueue.Enqueue(n.left);
            }
            if (n.right != null)
            {
                nodeQueue.Enqueue(n.right);
            }
        }
    }

    static Node insert(Node root, int data){
        if(root==null){
            return new Node(data);
        }
        else{
            Node cur;
            if(data<=root.data){
                cur=insert(root.left,data);
                root.left=cur;
            }
            else{
                cur=insert(root.right,data);
                root.right=cur;
            }
            return root;
        }
    }
    static void Main(String[] args){
        Node root=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            root=insert(root,data);            
        }
        levelOrder(root);
        
    } 
}

class Node{
    public Node left,right;
    public int data;
    public Node(int data){
        this.data=data;
        left=right=null;
    }
}