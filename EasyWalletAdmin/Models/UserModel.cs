using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EasyWalletAdmin.Models
{

    class UserModel:INotifyPropertyChanged 
    {
        private int id;

        public int Id
        {
            get => id;
            set { id = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string password;

        public  string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string token;

        public  string Token
        {
            get { return token; }
            set { token = value; }
        }




        public event PropertyChangedEventHandler PropertyChanged;
    }
}
