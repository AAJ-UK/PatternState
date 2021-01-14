using PatternState.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternState.Context
{
    /// <summary>
    /// This is the structure in which our states sit
    /// We set the local boxstate to one of the state classes, then in each method of this class (which has the same method names)
    /// we redirect the code to boxstate methods, in which the code varies depending on the current state
    /// </summary>
    class BoxContext : IBoxState
    {
        // create a local state. I've put accesors on the example but we do not actually need them
        // all the state control can be done witin this class.
        public IBoxState BoxState { get; set; }

        // when we instantiate a new box, we set its state to be undelivered
        public BoxContext()
        {
            BoxState = new BoxUndeliveredState();
        }

        /***********************************************************************************************/
        public void AcceptBox()
        {
            // When the method is called it calls the method of the current state class that has the same name

            BoxState.AcceptBox();
            // only allow the state of the box to move on to the next state if it is in the correct state for this method
            if (BoxState is BoxUndeliveredState)
            {
                BoxState = new BoxAcceptedState();
            }
        }

        public void ReturnBox()
        {
            // When the method is called it calls the method of the current state class that has the same name

            BoxState.ReturnBox();
            // only allow the state of the box to move on to the next state if it is in the correct state for this method
            if (BoxState is BoxAcceptedState)
            {
                BoxState = new BoxUndeliveredState();
            }
        }

        public void OpenBox()
        {
            // When the method is called it calls the method of the current state class that has the same name

            BoxState.OpenBox();
            // only allow the state of the box to move on to the next state if it is in the correct state for this method
            if (BoxState is BoxAcceptedState)
            {
                BoxState = new BoxOpenedState();
            }
        }

        public void EmptyBox()
        {
            // When the method is called it calls the method of the current state class that has the same name

            BoxState.EmptyBox();
            // only allow the state of the box to move on to the next state if it is in the correct state for this method
            if (BoxState is BoxOpenedState)
            {
                BoxState = new BoxEmptiedState();
            }

        }

        public void ThrowAwayBox()
        {
            // When the method is called it calls the method of the current state class that has the same name
            BoxState.ThrowAwayBox();
            // only allow the state of the box to move on to the next state if it is in the correct state for this method
            if (BoxState is BoxEmptiedState)
            {
                BoxState = new BoxThrownAwayState();
                BoxState = new BoxUndeliveredState();
            }
        }


    }
}
