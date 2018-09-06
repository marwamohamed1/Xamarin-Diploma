using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using EmployeesProject.Models;
using Xamarin.Forms;

namespace EmployeesProject.ViewModels
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        public EmployeeViewModel()
        {
            lstEmployees = new ObservableCollection<Employee>();
            Employee oEmployee = new Employee();
            oEmployee.EmployeeId = 1;
            oEmployee.EmployeeName = "alaa";
            oEmployee.EmployeeDepartment = "software";
            oEmployee.Position = "mini jiniour";
            oEmployee.Mobile = "01005658685685";
            oEmployee.Salary = 200;
            lstEmployees.Add(oEmployee);

            oEmployee = new Employee();
            oEmployee.EmployeeId = 2;
            oEmployee.EmployeeName = "hadir";
            oEmployee.EmployeeDepartment = "software";
            oEmployee.Position = "mini jiniour";
            oEmployee.Mobile = "5564565656456";
            oEmployee.Salary = 500;
            lstEmployees.Add(oEmployee);

            oEmployee = new Employee();
            oEmployee.EmployeeId = 3;
            oEmployee.EmployeeName = "azhar";
            oEmployee.EmployeeDepartment = "database";
            oEmployee.Position = "jiniour";
            oEmployee.Mobile = "564545";
            oEmployee.Salary = 500;
            lstEmployees.Add(oEmployee);

            oEmployee = new Employee();
            oEmployee.EmployeeId = 3;
            oEmployee.EmployeeName = "marwa";
            oEmployee.EmployeeDepartment = "design";
            oEmployee.Position = "seniour";
            oEmployee.Mobile = "8488948948948";
            oEmployee.Salary = 1000;
            lstEmployees.Add(oEmployee);

            BackCommand = new Command(BackButton);
            EmployeeTap = new Command<Employee>(OnEmployeeTap);
            AddCommand = new Command(OnAddEmployee);
            AddEmployeePage = new Command<Employee>(OnAddEmployeePage);
        }

        private async void OnAddEmployeePage(Employee obj)
        {
            var page = new Views.AddEmployee();
            Employee = new Employee();

            page.BindingContext = this;
            await App.Current.MainPage.Navigation.PushAsync(page);

        }

        private async void OnAddEmployee()
        {
            lstEmployees.Add(Employee);

            await App.Current.MainPage.Navigation.PopAsync();
        }

        void BackButton()
        {
            App.Current.MainPage.Navigation.PopAsync();
        }

        async void OnEmployeeTap(Employee paramter)
        {
            Employee = paramter;
            var page = new Views.EmployeeDetails();
            page.BindingContext = this;
            await App.Current.MainPage.Navigation.PushAsync(page);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand BackCommand { set; get; }
        public ICommand AddCommand { set; get; }

        public ICommand EmployeeTap { set; get; }
        public ICommand AddEmployeePage { get; set; }
        ObservableCollection<Employee> _lstemployee;
        public ObservableCollection<Employee> lstEmployees
        {
            set
            {
                _lstemployee = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("lstEmployees"));
                }
            }
            get
            {
                return _lstemployee;
            }
        }
        Employee _employee;
        public Employee Employee
        {
            set
            {
                _employee = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Employee"));
                }
            }
            get
            {
                return _employee;
            }

        }
    }
}
