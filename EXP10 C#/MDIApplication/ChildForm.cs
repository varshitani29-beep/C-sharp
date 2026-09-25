using System.Drawing;
using System.Windows.Forms;

namespace MDIApplication
{
    public class ChildForm : Form
    {
        Label label;

        public ChildForm()
        {
            Text = "Child Form";
            Width = 400;
            Height = 250;

            label = new Label();

            label.Text = "Welcome to MDI Application";
            label.AutoSize = true;
            label.Location = new Point(100, 80);

            Controls.Add(label);
        }

        public void SetMessage(string text)
        {
            label.Text = text;
        }
    }
}