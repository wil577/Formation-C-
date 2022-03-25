using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            //PhoneBook p = new PhoneBook();


            PhoneBook p = new PhoneBook();
            p.PhoneContact("0310101010");
            p.AddPhoneNumber("0310101010", "oui1");
            p.AddPhoneNumber("0410101010", "oui2");
            p.DeletePhoneNumber("0310101010");
            p.DisplayPhoneBook();

            BusinessSchedule b = new BusinessSchedule();
            b.SetRangeOfDates(DateTime.Today, DateTime.Today + TimeSpan.FromDays(7));
            b.AddBusinessMeeting(DateTime.Now, TimeSpan.FromHours(1));
            b.AddBusinessMeeting(DateTime.Now + TimeSpan.FromDays(2), TimeSpan.FromHours(1));
            b.DisplayMeetings();

            // Keep the console window open
            Console.WriteLine("-----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
