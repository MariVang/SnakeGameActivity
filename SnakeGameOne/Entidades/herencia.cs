using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace SnakeGameOne.Entidades
{
   public class Herencia : Cell, Inter
    {
        public void Messages()
        {
            Console.Write("Snake");
        }
    }
}
