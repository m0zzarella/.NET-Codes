using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagement_WinForms
{
    public partial class AddNewEmployee : Form
    {
        public AddNewEmployee()
        {
            InitializeComponent();
        }
        private void button7_click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = 8790060CC7795EB; database= WinForm_Employee; integrated security = true");
            SqlCommand cmd_newEmp = new SqlCommand("insert into EmployeeInfo values(@eNo, @eName, @eDesig, @eDeptNo, @eSal, @eStatus");


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

}