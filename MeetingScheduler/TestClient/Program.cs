using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClient.WFService;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application starting");
            Console.WriteLine("Calling workflow");
            WFService.IService service = new WFService.ServiceClient();
            WFService.User user = new WFService.User() { UserID = 1, FirstName = "sdf", Surname = "sdf", ContactPreference = ContactType.Email, ContactDetails = "sdfsdf" };
            WFService.User[] userarray = { user };
            Console.ReadKey();
            string thing = service.ScheduleMeeting(userarray, DateTime.Now);
            Console.WriteLine(thing);
            Console.ReadKey();
        }
    }
}
