namespace eUprava.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname  { get; set; }
        public string EMSO { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool isAdmin { get; set; } = false;
    }
}