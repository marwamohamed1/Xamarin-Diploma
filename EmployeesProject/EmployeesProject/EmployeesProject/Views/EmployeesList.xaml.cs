using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmployeesProject.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EmployeesList : ContentPage
	{
		public EmployeesList ()
		{
			InitializeComponent ();
            this.BindingContext = new ViewModels.EmployeeViewModel();

            NavigationPage.SetHasNavigationBar(this, false);
		}

      
        
    }
}