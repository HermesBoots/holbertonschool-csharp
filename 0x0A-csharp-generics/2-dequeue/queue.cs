using System;


/// <summary>Custom class that stores a queue of objects of the same type.</summary>
/// <typeparam name="T">Type stored in this collection.</typeparam>
class Queue<T>
{
    /// <summary>A node in the queue containing a single element of type <typeparamref name="T"/>.</summary>
    public class Node
    {
        /// <summary>The element stored in this node.</summary>
        public T value;
        /// <summary>Pointer to the next node in the queue.</summary>
        public Node next = null;

        /// <summary>Creates a new node with a given element.</summary>
        /// <param name="value">Initial value of node's element.</param>
        public Node(T value) {
            this.value = value;
        }
    }


    /// <summary>Pointer to the node at the front of the queue.</summary>
    public Node head;
    /// <summary>Pointer to the node at the back of the queue.</summary>
    public Node tail;
    /// <summary>Number of nodes in the queue.</summary>
    public int count = 0;


    /// <summary>Returns the type stored in this collection.</summary>
    /// <returns>Type of the <typeparamref name="T"/> generic parameter.</returns>
    public Type CheckType() {
        return typeof(T);
    }

    /// <summary>Returns the number of elements in the queue.</summary>
    /// <returns>Number of items in the queue.</returns>
    public int Count() {
        return this.count;
    }

    /// <summary>Removes the element at the front of the queue.</summary>
    /// <returns>The element at the front of the queue.</returns>
    public T Dequeue() {
        Node node;

        if (this.head == null) {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        node = this.head;
        this.head = node.next;
        this.count--;
        return node.value;
    }

    /// <summary>Adds a new element to the back of the queue.</summary>
    /// <param name="value">The new value to put in the queue.</param>
    public void Enqueue(T value) {
        Node node;

        node = new Node(value);
        if (this.head == null)
            this.head = node;
        if (this.tail != null)
            this.tail.next = node;
        this.tail = node;
        this.count++;
    }
}
