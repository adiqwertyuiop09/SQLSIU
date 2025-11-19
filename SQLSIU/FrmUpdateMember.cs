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
    public partial class FrmUpdateMember : Form
    {
        ClubRegistrationQuery clubRegistrationQuery = new ClubRegistrationQuery();

        public FrmUpdateMember()
        {
            InitializeComponent();       
            studCombo.SelectedIndexChanged += StudCombo_SelectedIndexChanged;
        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            List<long> studentIDs = clubRegistrationQuery.GetAllStudentIDs();

            studCombo.Items.Clear();
            foreach (long id in studentIDs)
            {
                studCombo.Items.Add(id);
            }

            if (studCombo.Items.Count > 0)
                studCombo.SelectedIndex = 0; 
        }

        
        private void StudCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studCombo.SelectedItem == null) return;

            long selectedID = long.Parse(studCombo.SelectedItem.ToString());

            DataRow student = clubRegistrationQuery.GetStudentByID(selectedID);

            if (student != null)
            {
                txtfn.Text = student["FirstName"].ToString();
                txtmn.Text = student["MiddleName"].ToString();
                txtln.Text = student["LastName"].ToString();
                txtage.Text = student["Age"].ToString();
                combogender.Text = student["Gender"].ToString();
                comboprogram.Text = student["Program"].ToString();
            }
            else
            {

                txtfn.Clear();
                txtmn.Clear();
                txtln.Clear();
                txtage.Clear();
                combogender.SelectedIndex = -1;
                comboprogram.SelectedIndex = -1;
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (studCombo.SelectedItem == null)
                {
                    MessageBox.Show("Please select a student.");
                    return;
                }

                long studentID = long.Parse(studCombo.SelectedItem.ToString());

                string first = txtfn.Text;
                string middle = txtmn.Text;
                string last = txtln.Text;
                int age = int.Parse(txtage.Text);
                string gender = combogender.Text;
                string program = comboprogram.Text;

                bool updated = clubRegistrationQuery.UpdateStudent(
                    studentID, first, middle, last, age, gender, program
                );

                if (updated)
                {
                    MessageBox.Show("Student updated successfully!");
                    this.Close(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }
    }
}
