using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using Xamarin;
using Parse;
using ParseSample.Pages;

namespace ParseSample.ViewModels
{
    public class SignUpViewModel : BaseViewModel
    {
        string firstName;
        string lastName;
        string username;
        string password;
        string email;

        Command signUpUserCommand;

        public SignUpViewModel()
        {
            Title = "Sign up";
        }


        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; OnPropertyChanged ("FirstName"); }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; OnPropertyChanged ("LastName"); }
        }

        public string Username
        {
            get { return username; }
            set { username = value; OnPropertyChanged ("Username"); }
        }

        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged ("Password"); }
        }

        public string Email 
        {
            get { return email; }
            set { email = value; OnPropertyChanged ("Email"); }
        }

        public Command SignUpUserCommand
        {
            get { return signUpUserCommand ?? (signUpUserCommand = new Command (async () => await ExecuteSignUpUserCommand ())); }
        }

        private async Task ExecuteSignUpUserCommand ()
        {
            if (IsBusy) {
                return;
            }

            IsBusy = true;

            var user = new ParseUser
            {
                Username = this.Username,
                Email = this.Email,
                Password = this.Password
            };
            user["firstName"] = this.FirstName;
            user["lastName"] = this.LastName;

            try
            {
                await user.SignUpAsync();
                //We'd normally do something else here...

            }
            catch (Exception ex) 
            {
                Insights.Report (ex);
            }

            IsBusy = false;
        }
    }

      
}

