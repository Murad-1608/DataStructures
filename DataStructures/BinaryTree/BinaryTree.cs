
namespace DataStructures.BinaryTree
{
    public class BinaryTree
    {
        private BinaryTreeNode root;

        public void Add(int item)
        {
            BinaryTreeNode newitem = new BinaryTreeNode(item);

            if (root == null)
            {
                root = newitem;
                return;
            }

            BinaryTreeNode iterator = root;

            while (true)
            {
                if (iterator.Value > item)
                {
                    if (iterator.Left == null)
                    {
                        iterator.Left = newitem;
                        return;
                    }
                    else iterator = iterator.Left;
                }
                else
                {
                    if (iterator.Right == null)
                    {
                        iterator.Right = newitem;
                        return;
                    }
                    else iterator = iterator.Right;
                }
            }
        }

        public void Remove(int item)
        {
            if (root == null)
            {
                return;
            }

            BinaryTreeNode iterator = new(item);

            if (iterator.Value == item)
            {
                // To Do: Remove root
            }

            while (true)
            {
                if (iterator.Value > item)
                {
                    if (iterator.Left == null)
                        return;

                    if (iterator.Left.Value == item)
                    {
                        if (iterator.Left.Left == null && iterator.Left.Right == null)
                        {
                            iterator.Left = null;
                        }
                    }
                    else
                    {
                        iterator = iterator.Left;
                    }
                }
                else
                {
                    if (iterator.Right == null)
                        return;

                    if (iterator.Right.Value == item)
                    {
                        if (iterator.Right.Left == null && iterator.Right.Right == null)
                        {
                            iterator.Right = null;
                        }
                    }
                    else
                    {
                        iterator = iterator.Right;
                    }
                }
            }
        }
    }
}
