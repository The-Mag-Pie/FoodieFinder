using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using FoodieFinder.Database;
using Android.OS;
using System.Security.Cryptography;

namespace FoodieFinder.UserAccount
{
    class Login
    {
        private User user { get; set; } = new User();
        private List<User> userlist {get; set;} = new List<User>();

        private AppDbContext _dbContext;

        public Login(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool CheckIfInDatabase(string email, string password)
        {
            if (IsEmail(email) && IsPasswordProvided(password))
            {
                user.Email = email;
                user.Password = password;
                userlist = _dbContext.User.ToList();
                int i = 0;
                while (userlist[i].Email != email)
                {
                    i++;
                }
                if (ComparePassword(user.Password, userlist[i].Password))
                {
                    _dbContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        private bool IsEmail(string input)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(input);
                return address.Address == input;
            }
            catch
            {
                return false;
            }
        }
        private bool IsPasswordProvided(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ComparePassword(string password, string hashedPassword)
        {
            using (var sha256 = SHA256.Create())
            {
                // Szyfrujemy podane hasło do postaci SHA-256
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var hashedInputPassword = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

                // Porównujemy z zaszyfrowanym hasłem
                return hashedInputPassword == hashedPassword;
            }
        }

    }
}
