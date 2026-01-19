namespace UserManagementSystem.ViewModels
{
    public class RegisterViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmed { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;

        public string PhoneNumberConfirmed { get; set;} = string.Empty; 
        public string EmailConfirmed { get; set; } = string.Empty;
         
            

    }
}
