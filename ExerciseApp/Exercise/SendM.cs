using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseApp.Exercise
{
    internal class SendM
    {
        //Named and optional params
        public static void SendMessage(string message, string recipient, bool isUrgent = false, DateTime? scheduledTime = null)
        {
            if (isUrgent) // if true
            {
                message = "URGENT: " + message; // + 'URGENT' to string
            }

            if (scheduledTime != null) // if not null
            {
                Console.WriteLine($"Message to {recipient} scheduled for {scheduledTime}: {message}");
            }
            else
            {
                Console.WriteLine($"Message sent to {recipient}: {message}");
            }
        }

        // Ini
        public SendM() 
        {
            SendMessage("Hello, how are you?", "John");

            SendMessage("Meeting postponed", "All employees", true);

            SendMessage("Reminder: project due in 2 days", "Project team", scheduledTime: DateTime.Now.AddDays(2));
        }

    }
}
