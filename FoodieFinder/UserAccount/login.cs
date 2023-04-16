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

        private static readonly string FullPath = Path.Combine(FileSystem.Current.AppDataDirectory, "UserData.json");

        public Login(IServiceProvider serviceProvider)
        {
            _dbContext = serviceProvider.GetRequiredService<AppDbContext>();
        }

        public bool CheckIfInDatabase(string email, string password)
        {
            if (IsEmail(email) && IsPasswordProvided(password))
            {
                //user.Email = email.ToLower();
                //user.Password = password;
                //userlist = _dbContext.User.ToList();
                //int i = 0;
                //var userData = _dbContext.User.Where(u => u.Email == email).First();
                //if (ComparePassword(user.Password, userData.Password))
                //{
                //    _dbContext.SaveChanges();
                //    return true;
                //}

                email = email.ToLower();
                try
                {
                    // Single() throws an exception when there is no exactly one element in collection
                    var userData = _dbContext.User.Where(u => u.Email == email).Single();

                    _dbContext.User.Entry(userData).Reload();

                    if (ComparePassword(password, userData.Password))
                    {
                        _dbContext.SaveChanges();
                        return true;
                    }
                }
                catch
                {
                    return false;
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
        public bool CreateSession(string username)
        {
            if (!File.Exists(FullPath))
            {
                CreateFileSession(FullPath);
            }
            string FileContent = File.ReadAllText(FullPath);
            var obj = JsonSerializer.Deserialize<SessionUser>(FileContent);
            string UserName = obj.Name;
            if (UserName == "none")
            {
                obj.Name = username.ToLower();
                obj.Id = GetIdFromEmail(obj.Name);
                
                FileContent = JsonSerializer.Serialize(obj);
                File.WriteAllText(FullPath, FileContent);
                return true;
            }
            return false;
        }
        public bool CheckIfSession()
        {
            try
            {
                string FileContent = File.ReadAllText(FullPath);
                var obj = JsonSerializer.Deserialize<SessionUser>(FileContent);
                string UserName = obj.Name;
                if (UserName != "none")
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public string GetUserNameSession() 
        {
            string FileContent = File.ReadAllText(FullPath);
            var obj = JsonSerializer.Deserialize<SessionUser>(FileContent);
            string UserName = obj.Name;
            return UserName;
        }
        public int GetUserIdSession()
        {
            string FileContent = File.ReadAllText(FullPath);
            var obj = JsonSerializer.Deserialize<SessionUser>(FileContent);
            int userid = obj.Id;
            return userid;
        }
        public bool DestroySession()
        {
            try
            {
                string FileContent = File.ReadAllText(FullPath);
                var obj = JsonSerializer.Deserialize<SessionUser>(FileContent);
                string UserName = obj.Name;
                if (UserName != "none")
                {
                    obj.Name = "none";
                    obj.Id = -1;
                    FileContent = JsonSerializer.Serialize(obj);
                    File.WriteAllText(FullPath, FileContent);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        private void CreateFileSession(string path)
        {
            var obj = new SessionUser
            {
                Id = -1,
                Name = "none"
            };
            string jsonString = JsonSerializer.Serialize(obj);
            File.WriteAllText(path, jsonString);
        }
        private int GetIdFromEmail(string email)
        {
            int userid = -1;
            var userData = _dbContext.User.Where(u => u.Email == email).Single();
            userid = userData.Id;
            return userid;
        }
    }
}
