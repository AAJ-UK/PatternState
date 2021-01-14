using PatternState.Context;
using System;

namespace PatternState
{
    class Program
    {/// <summary>
     /// An Example of using the State Pattern
     /// The state pattern is good for managing linear processes, but I find it can get very complicated very quickly.
     /// It allows you to call a method of a class to do something, but you are only allowed to do that thing if all the
     /// pre-requisites steps have been successfully completed. 
     /// in the past, I have used shift registers to move tokens up and down, but this is a nice and clever OOP way
     /// This example is about a box of things that have been ordered.
     /// The box can have a number of states, each state is an individual class which each class implements the IBoxState
     /// The IBoxState defines ALL the methods the system needs to be able to move from one state to another 
     /// e.g. AcceptBox(). Openbox(), RemoveContents() and GetRidOfBox(). this meach each state class has those methods
     /// We can put the code in these methods to reflect what each method can do in that particular state
     /// So If the state of the box is Undelivered, its openBox(), RemoveContents() and GetRidOfBox() dont do anything
     /// because before we can open the box, it must be delivered.
     /// 
     /// We then create a context class that also implements IBoxState, meaning the context class has all the same methods.
     /// The context class also has a local copy of IBoxState which we point to the current state of the object.
     /// So on statrt up, we set the local copy of IBoxState to BoxUndeliveredState.
     /// Then on each method, we intercept the normal Context class codes mthods, and tell them to execute the same method
     /// within the current local IBoxState. Take a look at the methods in the context class and it will make sense.
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            // States
            // create my context class
            BoxContext myBox = new BoxContext();

            // run through each step in order, the methods alter the state of the context box
            Console.WriteLine("box 1\n");
            myBox.AcceptBox();
            //myBox.ReturnBox();
            myBox.OpenBox();
            myBox.EmptyBox();
            myBox.ThrowAwayBox();

            // run through again,we try to open the box after it has been returned and the code refuses to allow us to do that. 
            Console.WriteLine("\nbox 2");
            myBox.AcceptBox();
            myBox.ReturnBox();
            myBox.OpenBox();
            myBox.EmptyBox();
            myBox.ThrowAwayBox();

            Console.WriteLine("\nbox 3");
            myBox.EmptyBox();
            


        }
    }
}
