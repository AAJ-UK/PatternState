using System;
using System.Collections.Generic;
using System.Text;

namespace PatternState.States
{
    interface IBoxState
    {
        // these are the methods that allow us to reach each state
        // Every state need to impement these methods

        // The method accept box sets the new state as Box Accepted 
        void AcceptBox();

        // The method return box sets the new state as Box Undelivered 
        void ReturnBox();

        // The method open box sets the new state as Box Opened
        void OpenBox();

        // The method remove contents sets the new state as Box Emptied
        void EmptyBox();

        // The method get rid of box sets the new state as Box thrown away 
        void ThrowAwayBox();


    }
}
