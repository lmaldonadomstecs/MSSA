using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyChanged
{
    public class Person : INotifyPropertyChanged
    {
        // Events
        public event PropertyChangedEventHandler PropertyChanged;

        // Fields
        private string firstName;
        private string lastName;
        private string fullName;

        // Properties
        public string FirstName
        {
            get { return firstName; }
            set { 
                firstName = value;
                updateUI("FullName"); // 
            } // Trigger Update UI
        }
        public string LastName
        {
            get { return lastName; }
            set { 
                lastName = value;
                updateUI("FullName");
            }
        }
        public string FullName
        {
            get { return fullName = firstName + " " + lastName; }
            set {  }
        }

        // Constructor
        public Person (string firstName = "John", string lastName = "Doe")
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.fullName = firstName + " " + lastName;
        }

        // Method
        public void updateUI(string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }































        //// Event of the INotifyPropertyChanged Interface
        //public event PropertyChangedEventHandler PropertyChanged;

        //// Fields
        //private string firstName;
        //private string lastName;
        //private string fullName;

        //// Properties
        //public string FirstName
        //{
        //    get { return firstName; }
        //    set {
        //        firstName = value;
        //        // If firstName changes NOTIFY to:
        //        OnPropertyChanged("FullName");
        //    } // Triggers OnPropertyChanged
        //}
        //public string LastName
        //{
        //    get { return lastName; }
        //    set {
        //        lastName = value;
        //        OnPropertyChanged("FullName");
        //    } // Triggers OnPropertyChanged
        //}
        //public string FullName
        //{
        //    get { return fullName = firstName + " " + lastName; }
        //    set { }
        //}

        //// Constructor
        //public Person (string firstName = "John", string lastName = "Doe")
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //}

        //// Methods
        //private void OnPropertyChanged(string property)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        //    // It's the same
        //    //if (PropertyChanged != null) {
        //    //    PropertyChanged(this, new PropertyChangedEventArgs(property));
        //    //}
        //}
    }
}
