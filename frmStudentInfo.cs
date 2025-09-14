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
