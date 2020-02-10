using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);
        if (aStack.Count > 0)
            Console.WriteLine("Top item: {0}", aStack.Peek());
        else
            Console.WriteLine("Stack is empty");
        if (aStack.Contains(search)) {
            Console.WriteLine("Stack contains \"{0}\": True", search);
            bool done = false;
            while (!done) {
                if (aStack.Peek().Equals(search))
                    done = true;
                aStack.Pop();
            }
        } else
            Console.WriteLine("Stack contains \"{0}\": False", search);
        aStack.Push(newItem);
        return aStack;
    }
}
