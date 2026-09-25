using System;
using System.Windows.Forms;

namespace MDIApplication
{
    public class MainForm : Form
    {
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem newMenu;
        private ToolStripMenuItem exitMenu;
        private ToolStripMenuItem windowMenu;
        private ToolStripMenuItem cascadeMenu;
        private ToolStripMenuItem tileMenu;

        public MainForm()
        {
            // MDI Form settings
            this.IsMdiContainer = true;
            this.Text = "MDI Application";
            this.Width = 800;
            this.Height = 500;

            // Create MenuStrip
            menuStrip = new MenuStrip();

            // File Menu
            fileMenu = new ToolStripMenuItem("File");

            newMenu = new ToolStripMenuItem("New");
            newMenu.Click += NewMenu_Click;

            exitMenu = new ToolStripMenuItem("Exit");
            exitMenu.Click += ExitMenu_Click;

            fileMenu.DropDownItems.Add(newMenu);
            fileMenu.DropDownItems.Add(exitMenu);

            // Window Menu
            windowMenu = new ToolStripMenuItem("Window");

            cascadeMenu = new ToolStripMenuItem("Cascade");
            cascadeMenu.Click += CascadeMenu_Click;

            tileMenu = new ToolStripMenuItem("Tile");
            tileMenu.Click += TileMenu_Click;

            windowMenu.DropDownItems.Add(cascadeMenu);
            windowMenu.DropDownItems.Add(tileMenu);

            // Add menus
            menuStrip.Items.Add(fileMenu);
            menuStrip.Items.Add(windowMenu);

            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }

        private void NewMenu_Click(object sender, EventArgs e)
        {
            ChildForm child = new ChildForm();
            child.MdiParent = this;
            child.Show();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CascadeMenu_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void TileMenu_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    // Child Form
    public class ChildForm : Form
    {
        public ChildForm()
        {
            this.Text = "Child Window";
            this.Width = 300;
            this.Height = 200;

            Label label = new Label();

            label.Text = "This is an MDI Child Form";
            label.AutoSize = true;
            label.Left = 70;
            label.Top = 70;

            this.Controls.Add(label);
        }
    }
}