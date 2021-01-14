using System;
using System.Collections.Generic;
using System.Text;

namespace PatternState.States
{
    class BoxAcceptedState : IBoxState
    {
        // See comments in IBoxState
        public void AcceptBox()
        {
            Console.WriteLine("No. You have already received the box");
        }

        public void ReturnBox()
        {
            Console.WriteLine("Yes. The Box has been returned");
        }

        public void OpenBox()
        {
            Console.WriteLine("Yes. The box is now opened");
        }

        public void EmptyBox()
        {
            Console.WriteLine("No. Cant remove contents of Box. It hasn't been opened yet");
        }

        public void ThrowAwayBox()
        {
            Console.WriteLine("No. Cant remove contents of Box. It hasn't been opened yet");
        }


    }
}
