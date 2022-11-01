using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGameOne.Entidades
{

    public class Cell
    {
        private string _val;
        public string val
        {
            get;
            set;
        }
        public int x
        {
            get;
            set;
        }
        private string _y;
        public int y
        {
            get;
            set;
        }
        private bool _visited;
        public bool visited
        {
            get;
            set;
        }
        private int _decay;
        public int decay
        {
            get;
            set;
        }

        public void decaySnake()
        {
            decay -= 1;
            if (decay == 0)
            {
                visited = false;
                val = " ";
            }
        }

        public void Clear()
        {
            val = " ";
        }

        public void Set(string newVal)
        {
            val = newVal;
        }
    }
}
