using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowValidation
{
    public class Form1 : Form
    {
        Label lblName;
        Label lblAge;
        Label lblEmail;
        Label lblMobile;

        TextBox txtName;
        TextBox txtAge;
        TextBox txtEmail;
        TextBox txtMobile;

        Button btnValidate;
        Button btnClear;

        public Form1()
        {
            CreateForm();
        }

        private void CreateForm()
        {
            // Form settings
            this.Text = "Window Validation";
            this.Width = 500;
            this.Height = 400;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Name Label
            lblName = new Label();
            lblName.Text = "Name";
            lblName.Location = new Point(50, 50);
            lblName.Width = 100;

            // Name TextBox
            txtName = new TextBox();
            txtName.Location = new Point(170, 45);
            txtName.Width = 250;

            // Age Label
            lblAge = new Label();
            lblAge.Text = "Age";
            lblAge.Location = new Point(50, 100);
            lblAge.Width = 100;

            // Age TextBox
            txtAge = new TextBox();
            txtAge.Location = new Point(170, 95);
            txtAge.Width = 250;

            // Email Label
            lblEmail = new Label();
            lblEmail.Text = "Email";
            lblEmail.Location = new Point(50, 150);
            lblEmail.Width = 100;

            // Email TextBox
            txtEmail = new TextBox();
            txtEmail.Location = new Point(170, 145);
            txtEmail.Width = 250;

            // Mobile Label
            lblMobile = new Label();
            lblMobile.Text = "Mobile Number";
            lblMobile.Location = new Point(50, 200);
            lblMobile.Width = 100;

            // Mobile TextBox
            txtMobile = new TextBox();
            txtMobile.Location = new Point(170, 195);
            txtMobile.Width = 250;

            // Validate Button
            btnValidate = new Button();
            btnValidate.Text = "Validate";
            btnValidate.Location = new Point(170, 250);
            btnValidate.Width = 100;

            // Clear Button
            btnClear = new Button();
            btnClear.Text = "Clear";
            btnClear.Location = new Point(280, 250);
            btnClear.Width = 100;

            // Button events
            btnValidate.Click += BtnValidate_Click;
            btnClear.Click += BtnClear_Click;

            // Add controls to Form
            this.Controls.Add(lblName);
            this.Controls.Add(txtName);

            this.Controls.Add(lblAge);
            this.Controls.Add(txtAge);

            this.Controls.Add(lblEmail);
            this.Controls.Add(txtEmail);

            this.Controls.Add(lblMobile);
            this.Controls.Add(txtMobile);

            this.Controls.Add(btnValidate);
            this.Controls.Add(btnClear);
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            // Name validation
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter your name.");
                txtName.Focus();
                return;
            }

            // Age validation
            int age;

            if (!int.TryParse(txtAge.Text, out age) ||
                age < 1 || age > 100)
            {
                MessageBox.Show("Please enter a valid age.");
                txtAge.Focus();
                return;
            }

            // Email validation
            string emailPattern =
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.");
                txtEmail.Focus();
                return;
            }

            // Mobile validation
            if (!Regex.IsMatch(txtMobile.Text, @"^[0-9]{10}$"))
            {
                MessageBox.Show(
                    "Mobile number must contain 10 digits.");

                txtMobile.Focus();
                return;
            }

            MessageBox.Show(
                "Validation Successful!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtEmail.Clear();
            txtMobile.Clear();

            txtName.Focus();
        }
    }
}
