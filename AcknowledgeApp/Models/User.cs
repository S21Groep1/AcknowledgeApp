namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Niveau { get; set; }
        public bool IsCoach { get; set; }
        public eFunctions Function { get; set; }
        public string Adress { get; set; }
    }
}