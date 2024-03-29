﻿using System.Text;
using FoodieFinder.Database;
using System.Security.Cryptography;

namespace FoodieFinder.UserAccount
{
    class Register
    {
        private User user { get; set; } = new User();
        private List<User> userlist { get; set; } = new List<User>();

        private AppDbContext _dbContext;

        public Register(IServiceProvider serviceProvider)
        {
            _dbContext = serviceProvider.GetRequiredService<AppDbContext>();
        }

        public bool AddToDatabase(string email, string password)
        {
            if (IsEmail(email) && IsPasswordProvided(password))
            {

                user.Email = email.ToLower();
                if (password == "auth0")
                {
                    user.Password = password;
                }
                else
                {
                    user.Password = EncryptPassword(password);
                }
                _dbContext.User.Add(user);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool CheckIfInDatabase(string email)
        {
            if (IsEmail(email))
            {
                user.Email = email.ToLower();
                userlist = _dbContext.User.ToList();
                int i = 0;
                while (userlist[i].Email != email.ToLower())
                {
                    if(i == userlist.Count-1)
                    {
                        return false;
                    }
                    i++;
                }
                
                    _dbContext.SaveChanges();
                    return true;

            }
            return false;
        }
        public bool IsEmail(string input)
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
        public string EncryptPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        public bool ComparePassword(string password, string hashedPassword)
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
