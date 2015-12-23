using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Module11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ArrayList students = new ArrayList();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student newStudent = new Student();
            newStudent.FirstName = txtFirstName.Text;
            newStudent.LastName = txtLastName.Text;
            newStudent.City = txtCity.Text;
            ClearForm();

            Task.Run(() => AddToCollection(newStudent));
        }


        private void AddToCollection(Student student)
        {
            // This line of code is intended to simulate network or database latency
            // It causes a non-responsive UI
            // Do not remove this line of code as a way of completing the assignment
            // You MUST use a C# task to get credit
            Thread.Sleep(2000);
            students.Add(student);
            int count = students.Count;
            MessageBox.Show("Student created successfully.  Collection contains " + count.ToString() + " Student(s).");
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            txtFirstName.Focus();
        }
    }

    class Student
    {
        private string firstName;
        private string lastName;
        private string city;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }


        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        public string City
        {
            get { return city; }
            set { city = value; }
        }
    }
}
