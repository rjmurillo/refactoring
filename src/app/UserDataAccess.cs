﻿using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace LegacyApp
{
    public static class UserDataAccess
    {
        public static void AddUser(User user, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("appDatabase");

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "usp_AddUser"
                };

                var firstNameParameter = new SqlParameter("@FirstName", SqlDbType.VarChar, 50) {Value = user.FirstName};
                command.Parameters.Add(firstNameParameter);
                var surnameParameter = new SqlParameter("@Surname", SqlDbType.VarChar, 50) { Value = user.Surname };
                command.Parameters.Add(surnameParameter);
                var dateOfBirthParameter = new SqlParameter("@DateOfBirth", SqlDbType.DateTime) { Value = user.DateOfBirth };
                command.Parameters.Add(dateOfBirthParameter);
                var emailAddressParameter = new SqlParameter("@EmailAddress", SqlDbType.VarChar, 50) { Value = user.EmailAddress };
                command.Parameters.Add(emailAddressParameter);
                var hasCreditLimitParameter = new SqlParameter("@HasCreditLimit", SqlDbType.Bit) { Value = user.HasCreditLimit };
                command.Parameters.Add(hasCreditLimitParameter);
                var creditLimitParameter = new SqlParameter("@CreditLimit", SqlDbType.Int) { Value = user.CreditLimit };
                command.Parameters.Add(creditLimitParameter);
                var clientIdParameter = new SqlParameter("@ClientId", SqlDbType.Int) { Value = user.Client.Id };
                command.Parameters.Add(clientIdParameter);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
