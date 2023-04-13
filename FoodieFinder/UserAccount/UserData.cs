namespace FoodieFinder.UserAccount
{
    /// <summary>
    /// Container class to store user data
    /// </summary>
    public class UserData
    {
        public bool IsGuest { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool IsAuth0 { get; set; } = false;
    }
}
