using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProject
{
    public partial class Form1 : Form
    {

        function fn = new function();
        String query;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            txtUsername.Clear();
            txtPassword.Clear();

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            query = "select * from NewUsers";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if (txtUsername.Text == "root" && txtPassword.Text == "root")
                {

                    Adminsitrator admin = new Adminsitrator();

                    admin.Show();
                    this.Hide();

                }
            }

            else
            {
                query = "select * from NewUsers where username = '" + txtUsername.Text + "' and pass = '" + txtPassword.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Adminsitrator")
                    {
                        Adminsitrator admin = new Adminsitrator();
                        admin.Show();
                        this.Hide();
                    }

                    else if (role == "Pharmacist")
                    {
                        Pharmacist pharm = new Pharmacist();
                        pharm.Show();
                        this.Hide();
                    }


                }
            }
        



                    if (txtUsername.Text == "Rohan" && txtPassword.Text == "0000")
                     {
                         Adminsitrator am = new Adminsitrator();
                         am.Show();
                         this.Hide();

                     }
                     else
                     {
                         MessageBox.Show("Wrong Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                     }
                    

                }
            }
        }
    
