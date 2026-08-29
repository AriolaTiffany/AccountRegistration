using System;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            cmbProgram.Items.AddRange(new object[]
            {
                "BS Computer Science (BSCS)",
                "BS Information Technology (BSIT)",
                "BS Computer Engineering (BSCpE)",
                "BS Business Administration (BSBA)",
                "BS Accounting Information System (BSAIS)",
                "BS Accountancy (BSA)",
                "BS Criminology (BSCRIM)",
                "BS Hospitality Management (BSHM)",
                "BS Tourism Management (BSTM)",
                "Bachelor of Multimedia Arts (BMMA)",
                "BS Psychology (BSPsych)",
                "Bachelor of Secondary Education Major in English",
                "Bachelor of Secondary Education Major in Mathematics",
                "Bachelor of Elementary Education"
            });
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentNo.Text) ||
                cmbProgram.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill out all required fields.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                StudentInfoClass.StudentNo = Int64.Parse(txtStudentNo.Text);
                StudentInfoClass.Age = Int64.Parse(txtAge.Text);
                StudentInfoClass.ContactNo = Int64.Parse(txtContact.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Student No., Age, and Contact No. must be numeric.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StudentInfoClass.Program = cmbProgram.Text;
            StudentInfoClass.LastName = txtLastName.Text;
            StudentInfoClass.FirstName = txtFirstName.Text;
            StudentInfoClass.MiddleName = txtMiddleName.Text;
            StudentInfoClass.Address = txtAddress.Text;

            using (FrmConfirm frmConfirm = new FrmConfirm())
            {
                DialogResult result = frmConfirm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ClearFields();
                }
            }
        }

        private void ClearFields()
        {
            txtStudentNo.Clear();
            cmbProgram.SelectedIndex = -1;
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtAge.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtStudentNo.Focus();
        }
    }
}