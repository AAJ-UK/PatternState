using System;
using System.Collections.Generic;
using System.Text;

namespace PatternState.States
{
    class BoxOpenedState : IBoxState
    {
       // See comments in IBoxState
        public void AcceptBox()
        {
            Console.WriteLine("No. You have already received the box");
        }

        public void ReturnBox()
        {
            Console.WriteLine("No. The Box has been opened");
        }

        public void OpenBox()
        {
            Console.WriteLine("No. The box is already opened");
        }

        public void EmptyBox()
        {
            Console.WriteLine("Yes. The contents of the box have been removed");
        }

        public void ThrowAwayBox()
        {
            Console.WriteLine("No. Cant remove contents of Box. It hasn't has its contents removed yet");
        }
    }
}
