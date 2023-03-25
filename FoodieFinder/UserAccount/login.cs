using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using FoodieFinder.Database;
using Android.OS;
using System.Security.Cryptography;
using FoodieFinder.Models;
using System.Text.Json;
using System.Net.Http.Json;

namespace FoodieFinder.UserAccount
{
    class Login
    {
        private User user { get; set; } = new User();
        private List<User> userlist { get; set; } = new List<User>();

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
                return hashedInputPassword == hashedPassword;
            }
        }
        private static readonly string FullPath = Path.Combine(FileSystem.Current.AppDataDirectory, "UserData.json");
        public static bool CreateSession(string username)
        {
            string FileContent = File.ReadAllText(FullPath);
            if (string.IsNullOrWhiteSpace(FileContent))
            {
                FileContent = username;
                File.WriteAllText(FullPath, FileContent);
                return true;
            }
            return false;
        }
        public static bool CheckIfSession()
        {
            string FileContent = File.ReadAllText(FullPath);
            if (string.IsNullOrWhiteSpace(FileContent))
            {
                return true;
            }
            return false;
        }
        public static string GetUserNameSession() 
        { 
            return File.ReadAllText(FullPath);
        }
        public static bool DestroySession()
        {
            string FileContent = File.ReadAllText(FullPath);
            if (string.IsNullOrWhiteSpace(FileContent))
            {
                FileContent = "";
                File.WriteAllText(FullPath, FileContent);
                return true;
            }
            return false;
        }
    }
}
