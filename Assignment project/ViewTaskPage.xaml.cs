using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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
    /// Interaction logic for ViewTaskPage.xaml
    /// </summary>
    public partial class ViewTaskPage : Page
    {
        Assignment1DBEntities1 db = new Assignment1DBEntities1();
        public int id;
        public ViewTaskPage(int id)
        {
            InitializeComponent();
            refreachdatagrid();
            refreachdatagridc();
            this.id = id;
            var rec = db.Users.FirstOrDefault(x => x.UserId == id);
            txtname.Content = $"Welcome empolyee {rec.UserName}";
        }

        public void refreachdatagrid()
        {
            var r = db.Taskes.Where(x => x.TaskStatus != "Completed").Select(x => new {x.TaskId , x.TaskTitle , x.TaskDescription , x.TaskStatus}).ToList();
            pdgtxt.ItemsSource = r;

        }

        public void refreachdatagridc()
        {
            var r = db.Taskes.Where(x => x.TaskStatus == "Completed").Select(x => new { x.TaskId, x.TaskTitle, x.TaskDescription, x.TaskStatus }).ToList();

            cdgtxt.ItemsSource = r;
        }

        //save
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //var id =  int.Parse(taskidtxt.Text);
            //var st = db.Taskes.FirstOrDefault(x=> x.TaskId == id);

        
            if (taskidtxt.Text != "")
            {
                string numbers = "0123456789";
                if(!taskidtxt.Text.Contains(numbers))
                {
                    var id = int.Parse(taskidtxt.Text);
                    var rec = db.Taskes.FirstOrDefault(x => x.TaskId == id);
                    if(rec != null)
                    {
                        if (ctxt.Text != "")
                        {
                            rec.TaskStatus = ctxt.Text;
                            db.Taskes.AddOrUpdate(rec);
                            db.SaveChanges();
                            refreachdatagrid();
                            refreachdatagridc();

                        }
                        else
                        {
                            MessageBox.Show("Most Choose Status");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not Found TaskID");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid TaskID Most be Numbers");
                }
            }
            else
            {
                MessageBox.Show("Enter TaskID :(");
            }
        }
        
    }
}
