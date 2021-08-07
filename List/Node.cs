using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    class Node
    {
        // variables
        public int data;
        public Node next;
        /// <summary>
        /// Constructor is used to Initialize the data.
        /// </summary>
        /// <param name="data"></param>
        public Node(int data)
        {
            this.data = data;
        }
    }
}
