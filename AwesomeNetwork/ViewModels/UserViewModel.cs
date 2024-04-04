using AwesomeNetwork.Models.Users;

namespace AwesomeNetwork.ViewModels
{
    public class UserViewModel
    {
        public User User { get; set; }

        public UserViewModel(User user)
        {
            User = user;
        }

    }
}
