using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment_project
{
    /// <summary>
    /// Interaction logic for Loginpage.xaml
    /// </summary>
    public partial class Loginpage : Page
    {
        Assignment1DBEntities1 db = new Assignment1DBEntities1();
          
        public Loginpage()
        {
            InitializeComponent();
            
            
        }
       
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

               var checkemail = db.Users.FirstOrDefault(x => x.UserEmail == emailtxt.Text && x.UserPassword == passtxt.Text);

                if(checkemail != null)
                {

                    if (checkemail.userRole == "Maneger")
                    {
                        MessageBox.Show("Welcome Back" + checkemail.UserName);

                        AddMangementPage addMangementPage = new AddMangementPage();
                        this.NavigationService.Navigate(addMangementPage);
                    }
                    else
                    {
                        ViewTaskPage viewTaskPage = new ViewTaskPage(checkemail.UserId);
                        this.NavigationService.Navigate(viewTaskPage);
                    }

                }
                else
                {
                    MessageBox.Show("Not Found email");
                }
  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {

            var checkemail = db.Users.FirstOrDefault(x => x.UserEmail == emailtxt.Text && x.UserPassword == passtxt.Text);

            ForgetPassword forgetPassword = new ForgetPassword(checkemail.UserEmail);
            this.NavigationService.Navigate(forgetPassword);



        }

        
    }
}
