using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLSIU
{
    public partial class FrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentID;

        private void updateBtn_Click(object sender, EventArgs e)
        {
            FrmUpdateMember updateForm = new FrmUpdateMember();
                     
            updateForm.ShowDialog();      
            RefreshListofClubMembers();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
              
                ID = RegistrationID();

               
                StudentID = long.Parse(studTxt.Text);
                FirstName = fnTxt.Text;
                MiddleName = mnTxt.Text;
                LastName = lnTxt.Text;
                Age = int.Parse(ageTxt.Text);
                Gender = genderCombo.Text;
                Program = programCombo.Text;

               
                bool success = clubRegistrationQuery.RegisterStudent(
                    ID,
                    StudentID,
                    FirstName,
                    MiddleName,
                    LastName,
                    Age,
                    Gender,
                    Program
                );

               
                if (success)
                {
                    MessageBox.Show("Registration successful!");
                    RefreshListofClubMembers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration failed: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            clubRegistrationQuery = new ClubRegistrationQuery();
            RefreshListofClubMembers();
        }

        public FrmClubRegistration()
        {
            InitializeComponent();
        }

        public void RefreshListofClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dgvClubMembers.DataSource = clubRegistrationQuery.bindingSource;
        }

        public int RegistrationID()
        {
            count++;
            return count;
        }


        private void refreshBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
