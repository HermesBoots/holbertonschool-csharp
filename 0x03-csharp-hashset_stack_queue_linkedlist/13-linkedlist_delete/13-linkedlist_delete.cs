using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < 0)
            return;
        LinkedListNode<int> node = myLList.First;
        while (node != null && index > 0) {
            node = node.Next;
            index--;
        }
        if (node != null)
            myLList.Remove(node);
    }
}
