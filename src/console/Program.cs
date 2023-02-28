// THIS CLASS MUST NOT CHANGE IN ANY WAY

using System;

namespace LegacyApp.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            ProveAddUser(args);
        }

        public static void ProveAddUser(string[] args)
        {
            var userService = new UserService();
            var addResult = userService.AddUser("Christine", "Koch", "christk@contoso.com", new DateTime(1971, 5, 12), -1965794451);

            Console.WriteLine("Adding user was " + (addResult ? "successful" : "unsuccessful"));
        }
    }
}