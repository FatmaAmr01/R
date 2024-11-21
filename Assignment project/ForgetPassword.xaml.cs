using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
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
    /// Interaction logic for ForgetPassword.xaml
    /// </summary>
    public partial class ForgetPassword : Page
    {
        Assignment1DBEntities1 db = new Assignment1DBEntities1();
        public string email;
        public ForgetPassword(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();

            if (email != null)
            {
                user.UserPassword = ptxt.Text;
                if (ptxt.Text == ctxt.Text)
                {

                    db.Users.AddOrUpdate(user);
                    db.SaveChanges();
                    MessageBox.Show("Password is updated ");
                }
                else
                {
                    MessageBox.Show("Not match ");
                }
            }
            else
            {
                MessageBox.Show("Not Found Email");
            }
           
        }
    }
}
