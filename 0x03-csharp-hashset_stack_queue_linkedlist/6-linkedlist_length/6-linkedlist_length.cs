using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        return (int)System.Linq.Enumerable.LongCount(myLList);
    }
}
