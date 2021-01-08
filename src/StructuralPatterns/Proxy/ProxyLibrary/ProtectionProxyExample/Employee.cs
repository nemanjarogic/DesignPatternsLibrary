namespace ProxyLibrary.ProtectionProxyExample
{
    public class Employee
    {
        public Employee(string username, string password, Role role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }
    }
}
