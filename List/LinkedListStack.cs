using System;

namespace List
{
    class LinkedListStack
    {
        private Node top;
        /// <summary>
        /// constructor is used to initialized the top.
        /// </summary>
        public LinkedListStack()
        {
            this.top = null;
        }
        /// <summary>
        /// Add element into stack.
        /// </summary>
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = this.top;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }
        /// <summary>
        /// Display the stack elements.
        /// </summary>
        public void Display()
        {
            Node temp = this.top;
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        /// <summary>
        /// Display the top element of the stack.
        /// </summary>
        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is Peek element of Stack", top.data);
        }
        /// <summary>
        /// Remove the top element from stack.
        /// </summary>
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is Poped from the Stack", top.data);
            Console.WriteLine("********");
            top = top.next;
        }
        /// <summary>
        /// It will pop out all the elements from stack until stack is empty.
        /// </summary>
        public void ISEmpty()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            while (top != null)
            {
                Peek();
                Pop();
            }
        }

    }
}