using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsControls
{
    public partial class Form1 : Form
    {
        TextBox txtName;
        RadioButton rdoMale;
        RadioButton rdoFemale;
        ComboBox cmbCourse;
        CheckBox chkSports;
        CheckBox chkMusic;
        Button btnSubmit;
        Button btnClear;

        public Form1()
        {
            InitializeComponent();

            // Form settings
            this.Text = "Student Details";
            this.Size = new Size(450, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Name Label
            Label lblName = new Label();
            lblName.Text = "Name:";
            lblName.Location = new Point(40, 40);
            lblName.AutoSize = true;
            this.Controls.Add(lblName);

            // Name TextBox
            txtName = new TextBox();
            txtName.Location = new Point(150, 37);
            txtName.Width = 200;
            this.Controls.Add(txtName);

            // Gender Label
            Label lblGender = new Label();
            lblGender.Text = "Gender:";
            lblGender.Location = new Point(40, 90);
            lblGender.AutoSize = true;
            this.Controls.Add(lblGender);

            // Male RadioButton
            rdoMale = new RadioButton();
            rdoMale.Text = "Male";
            rdoMale.Location = new Point(150, 88);
            this.Controls.Add(rdoMale);

            // Female RadioButton
            rdoFemale = new RadioButton();
            rdoFemale.Text = "Female";
            rdoFemale.Location = new Point(250, 88);
            this.Controls.Add(rdoFemale);

            // Course Label
            Label lblCourse = new Label();
            lblCourse.Text = "Course:";
            lblCourse.Location = new Point(40, 140);
            lblCourse.AutoSize = true;
            this.Controls.Add(lblCourse);

            // Course ComboBox
            cmbCourse = new ComboBox();
            cmbCourse.Location = new Point(150, 137);
            cmbCourse.Width = 200;

            cmbCourse.Items.Add("B.Sc Computer Science");
            cmbCourse.Items.Add("BCA");
            cmbCourse.Items.Add("B.Sc Mathematics");
            cmbCourse.Items.Add("B.Com");
            cmbCourse.Items.Add("BBA");

            this.Controls.Add(cmbCourse);

            // Hobbies Label
            Label lblHobbies = new Label();
            lblHobbies.Text = "Hobbies:";
            lblHobbies.Location = new Point(40, 190);
            lblHobbies.AutoSize = true;
            this.Controls.Add(lblHobbies);

            // Sports CheckBox
            chkSports = new CheckBox();
            chkSports.Text = "Sports";
            chkSports.Location = new Point(150, 188);
            this.Controls.Add(chkSports);

            // Music CheckBox
            chkMusic = new CheckBox();
            chkMusic.Text = "Music";
            chkMusic.Location = new Point(250, 188);
            this.Controls.Add(chkMusic);

            // Submit Button
            btnSubmit = new Button();
            btnSubmit.Text = "Submit";
            btnSubmit.Location = new Point(150, 250);
            btnSubmit.Width = 90;
            btnSubmit.Click += btnSubmit_Click;
            this.Controls.Add(btnSubmit);

            // Clear Button
            btnClear = new Button();
            btnClear.Text = "Clear";
            btnClear.Location = new Point(260, 250);
            btnClear.Width = 90;
            btnClear.Click += btnClear_Click;
            this.Controls.Add(btnClear);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            string gender = "";

            if (rdoMale.Checked)
                gender = "Male";
            else if (rdoFemale.Checked)
                gender = "Female";

            string course = cmbCourse.Text;

            string hobbies = "";

            if (chkSports.Checked)
                hobbies += "Sports ";

            if (chkMusic.Checked)
                hobbies += "Music ";

            MessageBox.Show(
                "Name : " + name +
                "\nGender : " + gender +
                "\nCourse : " + course +
                "\nHobbies : " + hobbies,
                "Student Details");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();

            rdoMale.Checked = false;
            rdoFemale.Checked = false;

            chkSports.Checked = false;
            chkMusic.Checked = false;

            cmbCourse.SelectedIndex = -1;
        }
    }
}
