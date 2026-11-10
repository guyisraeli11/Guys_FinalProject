using System;
using System.Collections.Generic;
using System.Text;

namespace Guys_FinalProject.ViewModels
{
    internal class LogInPageModels : ViewModelBase
    {
        private string email = "";
        public string Email
        {
            get => email;
            set
            {
                if (email == value) return;
                email = value;
                OnPropertyChanged();
            }
        }
        private string password = "";
        public string Password
        {
            get => password;
            set
            {
                if (password == value) return;
                password = value;
                OnPropertyChanged();
            }
        }
    }
}
