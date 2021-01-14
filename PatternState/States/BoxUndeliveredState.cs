using System;
using System.Collections.Generic;
using System.Text;

namespace PatternState.States
{
    class BoxUndeliveredState : IBoxState
    {
        // See comments in IBoxState
        public void AcceptBox()
        {
            Console.WriteLine("You have received the box");
        }

        public void ReturnBox()
        {
            Console.WriteLine("No. Cant return Box. It isn't here yet");
        }

        public void OpenBox()
        {
            Console.WriteLine("No. Cant Open the Box. It isn't here yet");
        }

        public void EmptyBox()
        {
            Console.WriteLine("No. Cant remove contents of Box. It isn't here yet");
        }
          
        public void ThrowAwayBox()
        {
            Console.WriteLine("No. Cant Get Rid Of Box. It isn't here yet");
        }
    }
}
