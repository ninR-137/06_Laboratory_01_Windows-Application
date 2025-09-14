
## Github [URL](https://github.com/ninR-137/06_Laboratory_01_Windows-Application.git)


# Sample Output:
[image](https://i.postimg.cc/T2L9CnsD/Capture.png)


# StudentNameSpace

```C#
using System;

namespace StudentNameSpace
{
    public class StudentInfo
    {
        private string _firstName;
        private string _lastName;
        private string _studentID;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }

        public StudentInfo(string firstName, string lastName, string studentID)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._studentID = studentID;
        }

        public StudentInfo()
        {
        }
    }
}

```


# frmStudentInfo

```C#
using StudentNameSpace;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        //Simulate a database with a list
        List<StudentInfo> students = new List<StudentInfo>();

        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //check if all params are filled
            if(studentId.Text == "" || firstName.Text == "" || lastName.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            //create student object
            StudentInfo student = new StudentInfo(firstName.Text, lastName.Text, studentId.Text);

            //add to list
            students.Add(student);

            //clear textboxes
            studentId.Text = "";
            firstName.Text = "";
            lastName.Text = "";

            //Add to listboxes
            studentIdList.Items.Add(student.StudentID);
            firstNameList.Items.Add(student.FirstName);
            lastNameList.Items.Add(student.LastName);
        }
    }
}

```

