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
    class Register
    {
        //public List <User> users = new List<User> ();
        private User user { get; set; }

        private AppDbContext _dbContext;

        public Register(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddToDatabase(string email, string password)
        {
            if (IsEmail(email) && IsPasswordProvided(password))
            {
                user.Email = email;
                user.Password = EncryptPassword(password);
                _dbContext.User.Add(user);
                _dbContext.SaveChanges();
                return true;
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
        private string EncryptPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
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
