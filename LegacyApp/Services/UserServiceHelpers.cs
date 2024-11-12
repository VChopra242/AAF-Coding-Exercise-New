using LegacyApp.Models.Domain;
using LegacyApp.Models.Domain.DTO;
using LegacyApp.Services;
using System;

public static class UserServiceHelpers
{

    public static void CheckCreditLimit(User user)
    {
        if (user.HasCreditLimit && user.CreditLimit < 500)
        {
            throw new InvalidOperationException("insufficient credit limit");
        }
    }

    public static void CheckEmail(UserDTO userDto)
    {
        if (!userDto.Email.Contains("@") && !userDto.Email.Contains("."))
        {
            throw new InvalidOperationException("user email is invalid ");
        }
    }

    public static void CheckUserAge(UserDTO userDto)
    {
        var now = DateTime.Now;
        int age = now.Year - userDto.DateOfBirth.Year;
        if (now.Month < userDto.DateOfBirth.Month || now.Month == userDto.DateOfBirth.Month && now.Day < userDto.DateOfBirth.Day) age--;

        if (age < 21)
        {
            throw new InvalidOperationException("user should be older than 21 years");
        }
    }

    public static void CheckUserName(UserDTO userDto)
    {
        if (string.IsNullOrEmpty(userDto.FirstName) || string.IsNullOrEmpty(userDto.Surname))
        {
            throw new InvalidOperationException("user firstname / surname is required ");
        }
    }

    public static void VerifyClient(Client client, User user)
    {
        if (client.Name == "VeryImportantClient")
        {
            // Skip credit check
            user.HasCreditLimit = false;
        }
        else if (client.Name == "ImportantClient")
        {
            // Do credit check and double credit limit
            user.HasCreditLimit = true;
            using (var userCreditService = new UserCreditServiceClient())
            {
                var creditLimit = userCreditService.GetCreditLimit(user.Firstname, user.Surname, user.DateOfBirth);
                creditLimit = creditLimit * 2;
                user.CreditLimit = creditLimit;
            }
        }
        else
        {
            // Do credit check
            user.HasCreditLimit = true;
            using (var userCreditService = new UserCreditServiceClient())
            {
                var creditLimit = userCreditService.GetCreditLimit(user.Firstname, user.Surname, user.DateOfBirth);
                user.CreditLimit = creditLimit;
            }
        }
    }
}