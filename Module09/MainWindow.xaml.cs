using System.Collections.Generic;
using System.Windows;

namespace Module09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> students = new List<Student>();
        int currentIndex = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student();

            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.City = txtCity.Text;

            students.Add(student);

            this.Clear();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            currentIndex ++;

            if(currentIndex >= students.Count)
            {
                currentIndex = students.Count - 1;
            }
            else
            {
                DisplayStudent();
            }
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            currentIndex--;

            if (currentIndex < 0)
            {
                currentIndex = 0;
            }
            else
            {
                DisplayStudent();
            }
        }

        private void DisplayStudent()
        {
            Student student = students[currentIndex];
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtCity.Text = student.City;
        }

        private void UpdateNavigationButtons()
        {
            if(currentIndex == students.Count)
            {
                btnNext.IsEnabled = false;
            }

            else if(currentIndex == 0)
            {
                btnPrevious.IsEnabled = false;
            }
        }

        private void Clear()
        {
            txtCity.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            currentIndex = -1;
            btnPrevious.IsEnabled = false;            
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }

}
