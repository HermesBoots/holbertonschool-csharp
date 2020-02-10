using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        return (new HashSet<int>(myList)).Sum();
    }
}
