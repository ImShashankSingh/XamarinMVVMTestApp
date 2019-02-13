using System;
using System.Windows.Input;
using TestingApp.Data;
using TestingApp.Models;
using Xamarin.Forms;

namespace TestingApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region private properties

        private string _firstName;
        private string _lastName;
        private int _age;

        #endregion

        #region public properties

        public ICommand SaveCommand { get; set; }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set 
            {
                SetProperty(ref _firstName, value);
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                SetProperty(ref _lastName, value);
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                SetProperty(ref _age, value);
            }
        }

        #endregion

        #region public methods

        public MainViewModel()
        {
            SaveCommand = new Command(OnSave);
        }

        #endregion

        #region private methods

        private void OnSave()
        {
            var isValidData = Validate();
            if (!isValidData)
                return;

            var employee = new Employee()
            {
                FirstName = FirstName,
                LastName = LastName,
                Age = Age
            };

            Repository.SaveOrUpdate(employee);
        }

        private bool Validate()
        {
            if (string.IsNullOrEmpty(FirstName))
            {
                DisplayError("Alert", "First name cannot be blank", "Ok");
                return false;
            }

            if (string.IsNullOrEmpty(LastName))
            {
                DisplayError("Alert", "Last name cannot be blank", "Ok");
                return false;
            }

            return true;
        }

        #endregion
    }
}
