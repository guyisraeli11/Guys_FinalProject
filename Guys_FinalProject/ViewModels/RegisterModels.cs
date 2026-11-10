using System;
using System.Collections.Generic;
using System.Text;

namespace Guys_FinalProject.ViewModels
{
    internal class RegisterModels : ViewModelBase
    {
        private string fullName = "";
        public string FullName
        {
            get => fullName;
            set
            {
                if (fullName == value) return;
                fullName = value;
                OnPropertyChanged();
            }
        }
        private string userName = "";
        public string UserName
        {
            get => userName;
            set
            {
                if (userName == value) return;
                userName = value;
                OnPropertyChanged();
            }
        }
        private string emailPassword = "";
        public string EmailPassword
        {
            get => emailPassword;
            set
            {
                if (emailPassword == value) return;
                emailPassword = value;
                OnPropertyChanged();
            }
        }
    }
}
