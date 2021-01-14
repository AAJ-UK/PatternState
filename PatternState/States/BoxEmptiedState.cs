using System;
using System.Collections.Generic;
using System.Text;

namespace PatternState.States
{
    class BoxEmptiedState : IBoxState
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
            Console.WriteLine("No. The box is already empty");
        }

        public void ThrowAwayBox()
        {
            Console.WriteLine("Yes. The box has been thrown away");
        }

    }
}
