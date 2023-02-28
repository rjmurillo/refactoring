using System;

namespace LegacyApp
{
    public class User
    {
        public bool HasCreditLimit { get; set; }
        public int CreditLimit { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Client Client { get; set; }
        public string EmailAddress { get; set; }
    }
}