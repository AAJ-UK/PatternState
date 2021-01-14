using System;
using System.Collections.Generic;
using System.Text;

namespace PatternState.States
{
    class BoxThrownAwayState : IBoxState
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
            Console.WriteLine("No. The contents of the box have alreasy been removed");
        }

        public void ThrowAwayBox()
        {
            Console.WriteLine("No. There is no box. Its already been thrown away");
        }
    }
}
