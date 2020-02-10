using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = myLList.First;
        while (node != null && node.Value < n)
            node = node.Next;
        if (node == null) {
            myLList.AddLast(n);
            return myLList.Last;
        }
        myLList.AddBefore(node, n);
        return node.Previous;
    }
}
