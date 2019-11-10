using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EasyWalletAdmin.Models
{
    internal class ProductModel:INotifyPropertyChanged
    {
        private  int id;

        public  int Id  
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int description;

        public int Description
        {
            get { return description; }
            set { description = value; }
        }

        private string expiration_date;

        public string Expiration_date
        {
            get { return expiration_date; }
            set { expiration_date = value; }
        }


        public event PropertyChangedEventHandler PropertyChanged;

    }
}
