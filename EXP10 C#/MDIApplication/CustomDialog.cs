using System.Drawing;
using System.Windows.Forms;

namespace MDIApplication
{
    public class CustomDialog : Form
    {
        TextBox textBox;

        public string MessageText
        {
            get
            {
                return textBox.Text;
            }
        }

        public CustomDialog()
        {
            Text = "Custom Dialog Box";
            Width = 400;
            Height = 180;

            StartPosition = FormStartPosition.CenterParent;

            Label label = new Label();
            label.Text = "Enter your message:";
            label.Location = new Point(30, 25);
            label.AutoSize = true;

            textBox = new TextBox();
            textBox.Location = new Point(30, 50);
            textBox.Width = 300;

            Button ok = new Button();
            ok.Text = "OK";
            ok.Location = new Point(170, 90);
            ok.DialogResult = DialogResult.OK;

            Button cancel = new Button();
            cancel.Text = "Cancel";
            cancel.Location = new Point(250, 90);
            cancel.DialogResult = DialogResult.Cancel;

            Controls.Add(label);
            Controls.Add(textBox);
            Controls.Add(ok);
            Controls.Add(cancel);

            AcceptButton = ok;
            CancelButton = cancel;
        }
    }
}