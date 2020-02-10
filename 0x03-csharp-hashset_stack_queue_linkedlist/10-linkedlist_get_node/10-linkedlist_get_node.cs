using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n < 0 || n >= (myLList?.Count ?? 0))
            return 0;
        return System.Linq.Enumerable.ElementAt(myLList, n);
    }
}
