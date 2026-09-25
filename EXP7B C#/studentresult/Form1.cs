using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentResult
{
    public class Form1 : Form
    {
        Button button1;

        public Form1()
        {
            button1 = new Button();

            button1.Text = "View Result";
            button1.Size = new Size(120, 40);
            button1.Location = new Point(130, 80);

            button1.Click += button1_Click;

            this.Controls.Add(button1);

            this.Text = "Student Result";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(400, 250);
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to view your result?",
                "Student Result",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Congratulations! You have passed.",
                    "Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Result viewing cancelled.",
                    "Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}