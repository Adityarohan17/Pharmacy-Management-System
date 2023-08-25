using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProject.AdminsitratorUC
{
    public partial class UC_AddUser : UserControl
    {
        function fn = new function();
        String query;

        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text;
            Int64 contact = Int64.Parse(txtContactNo.Text);
            String email = txtEmailid.Text;
            String username = txtUsername.Text;
            String pass = txtPassword.Text;


            try
            {
                query = "insert into NewUsers(userRole,name,dob,contact,email,username,pass) values ('" + role + "', '" + name + "', '" + dob + "'," + contact + ", '" + email + "', '" + username + "', '" + pass + "')";
                fn.setData(query, "Sign Up succesful,");

            }
            catch (Exception)
            {
                MessageBox.Show("Username Alredy exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtName.Clear();
            txtDob.ResetText();
            txtContactNo.Clear();
            txtEmailid.Clear();
            txtUsername.ClearUndo();
            txtPassword.Clear();
            txtUserRole.SelectedIndex = -1;

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from  NewUsers where username = '" + txtUsername.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"C:\Users\Rohan Aditya\Videos\Captures\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Users\Rohan Aditya\Videos\Captures\no.png";
            }
        }
    }
}
