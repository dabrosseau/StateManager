using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StateManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valid states are: Pending, Approved, Rejected");
            Console.WriteLine("Valid events are: Add, Update, Approve, Reject");
            Console.WriteLine("");

            Console.WriteLine("Enter the current state:");
            string currentState = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Enter the event:");
            string theEvent = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine(GetNewState(currentState, theEvent));

            Console.Read();

            // This is an update to the update.
            // This comment was added on GitHub in the master branch.
            // This comment was added in VS.
            // Yet another comment made in GitHub.
            
        }

        static private string GetNewState(string currentState, string theEvent)
        {
            string result = "";

            switch (theEvent)
            {
                case "Add":
                    result = "No current state. New record. New state is Pending.";
                    break;

                case "Update":
                    if (currentState == "Approved") result = "New state is Pending.";
                    else if (currentState == "Pending") result = "New state is Pending.";
                    else if (currentState == "Rejected") result = "New state is Pending.";
                    else result = "Invalid: Can't " + theEvent + " when state is " + currentState;
                    break;

                case "Approve":
                    if (currentState == "Pending") result = "New state is Approved.";
                    else result = "Invalid: Can't " + theEvent + " when state is " + currentState;
                    break;

                case "Reject":
                    if (currentState == "Pending") result = "New state is Rejected.";
                    else result = "Invalid: Can't " + theEvent + " when state is " + currentState;
                    break;

                default:
                    break;

            }

            return result;
        }
    }
}
