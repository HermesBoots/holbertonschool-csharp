using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set = new HashSet<int>(list1);
        set.IntersectWith(list2);
        List<int> list = new List<int>(set);
        list.Sort();
        return list;
    }
}
