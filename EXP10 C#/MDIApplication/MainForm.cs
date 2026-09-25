using System;
using System.Windows.Forms;

namespace MDIApplication
{
    public class MainForm : Form
    {
        MenuStrip menu;
        ToolStripMenuItem fileMenu;
        ToolStripMenuItem newForm;
        ToolStripMenuItem dialog;
        ToolStripMenuItem exit;

        public MainForm()
        {
            Text = "MDI Application";
            Width = 800;
            Height = 500;
            IsMdiContainer = true;

            menu = new MenuStrip();

            fileMenu = new ToolStripMenuItem("File");
            newForm = new ToolStripMenuItem("New Form");
            dialog = new ToolStripMenuItem("Custom Dialog");
            exit = new ToolStripMenuItem("Exit");

            newForm.Click += (s, e) =>
            {
                ChildForm f = new ChildForm();
                f.MdiParent = this;
                f.Show();
            };

            dialog.Click += (s, e) =>
            {
                CustomDialog d = new CustomDialog();

                if (d.ShowDialog() == DialogResult.OK)
                {
                    ChildForm f = new ChildForm();
                    f.MdiParent = this;
                    f.SetMessage(d.MessageText);
                    f.Show();
                }
            };

            exit.Click += (s, e) =>
            {
                Application.Exit();
            };

            fileMenu.DropDownItems.Add(newForm);
            fileMenu.DropDownItems.Add(dialog);
            fileMenu.DropDownItems.Add(exit);

            menu.Items.Add(fileMenu);

            Controls.Add(menu);
            MainMenuStrip = menu;
        }
    }
}