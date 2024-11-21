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
    /// Interaction logic for AddMangementPage.xaml
    /// </summary>
    public partial class AddMangementPage : Page
    {
        Assignment1DBEntities1 db = new Assignment1DBEntities1();
        public AddMangementPage()
        {
            InitializeComponent();
            dg.ItemsSource = db.Taskes.Select(x => new { x.User.UserEmail, x.TaskId, x.TaskTitle ,x.TaskDescription, x.TaskStatus }).ToList();
        }
   

        // Add 
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Taske task = new Taske();

            if (titletxt.Text !="" && dtxt.Text != "" && emailtxt.Text!="")
            {
                var email = db.Users.FirstOrDefault(x => x.UserEmail == emailtxt.Text);
                if (email != null)
                {
                    task.TaskTitle = titletxt.Text;
                    task.TaskDescription = dtxt.Text;
                    task.TaskStatus = statxt.Text; 
                    task.userid = email.UserId; 
                    db.Taskes.Add(task);   
                    db.SaveChanges();
                    dg.ItemsSource = db.Taskes.Select(x => new { x.TaskId, x.TaskTitle, x.TaskDescription, x.TaskStatus , x.User.UserEmail }).ToList();
                    MessageBox.Show("You Add A New Task From " + emailtxt.Text);
                }
                else
                {
                    MessageBox.Show("Not Found This Email");
                }

            }
            else
            {
                MessageBox.Show("You Most not take Title of task or Description of Task OR Email Of User Is Empty :(");
            }


        }

        // Delet
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Taske task = new Taske();
            var id = int.Parse(taskidtxt.Text);
            var rec = db.Taskes.FirstOrDefault(x => x.TaskId==id); 
            
             if (rec != null)
             {
                string n = "0123456789";
                if(!taskidtxt.Text.Contains(n))
                {
                    db.Taskes.Remove(rec);
                    db.SaveChanges();
                    MessageBox.Show("You Deleted Task" + id + " From " + emailtxt.Text);
                    dg.ItemsSource = db.Taskes.Select(x => new { x.TaskId, x.TaskTitle, x.TaskDescription, x.TaskStatus, x.User.UserEmail }).ToList();
                }
                else
                {
                    MessageBox.Show("Invalid TaskID Most be Numbers");
                }

             }
             else
             {
                MessageBox.Show("Not Found TaskID");
             }

        }

        // update
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (titletxt.Text != "" && statxt.Text != "" && taskidtxt.Text != "")
            {
                var id = int.Parse(taskidtxt.Text);
                var rec = db.Taskes.FirstOrDefault(x => x.TaskId == id);
                string n = "0123456789";
                if (!taskidtxt.Text.Contains(n))
                {
                    if (rec != null)
                    {
                        rec.TaskTitle = titletxt.Text;
                        rec.TaskDescription = dtxt.Text;
                        rec.TaskStatus = statxt.Text;
                        db.Taskes.AddOrUpdate(rec);
                        db.SaveChanges();
                        MessageBox.Show("Recoud Updated");
                        dg.ItemsSource = db.Taskes.Select(x => new { x.TaskId, x.TaskTitle, x.TaskDescription, x.TaskStatus, x.User.UserEmail }).ToList();

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
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Taske taske = new Taske();
            taske.TaskStatus = statxt.Text.ToString();
                db.Taskes.Where(x=> x.TaskStatus == statxt.Text);
            dg.ItemsSource = db.Taskes.Where(x=> x.TaskStatus == statxt.Text).Select(x => new { x.TaskId, x.TaskTitle, x.TaskDescription, x.TaskStatus, x.User.UserEmail }).ToList();

        }
    }
    
}
