
// Amir Moeini Rad
// September 2025

// Main Concept: Windows Forms Button Control plus Various Events


using System;
using System.Windows.Forms;
using System.Drawing;


namespace Buttons
{
    // The 'Form' class represents a window or dialog box that makes up an application's user interface.
    public class ButtonApp : Form
    {
        // 'Label' and 'Button' classes are controls used in Windows Forms applicatons.
        private Label myDateLabel;
        private Button btnUpdate;
        private Button btnOk;


        // Constructor
        public ButtonApp()
        {        
            InitializeComponent();
        }


        // A custom method to initialize form components.
        private void InitializeComponent()
        {
            // 'Text' property sets the title of the form.
            // 'Environment.CommandLine' returns the path of the application's executable file.
            Text = Environment.CommandLine;

            // 'StartPosition' property sets the initial position of the form when it is first displayed.
            StartPosition = FormStartPosition.CenterScreen;

            // 'FormBorderStyle' property sets the border style of the form.
            FormBorderStyle = FormBorderStyle.Fixed3D;

            // Create a label control to be displayed on the form.
            myDateLabel = new Label();

            // Get the current date and time of the computer.
            DateTime currDate = new DateTime();
            currDate = DateTime.Now;

            // Display the current date and time in the label.
            myDateLabel.Text = currDate.ToString();

            // Set properties of the label
            myDateLabel.AutoSize = true;
            myDateLabel.Location = new Point(50, 20);
            myDateLabel.BackColor = BackColor;

            // Add the label to form (Display the label on the form.)
            Controls.Add(myDateLabel);

            // Set the width of the form based on the label’s width
            Width = (myDateLabel.PreferredWidth + 100);

            // Create a button control.
            btnUpdate = new Button();

            // Set properties of the button.
            btnUpdate.Text = "Update";
            btnUpdate.BackColor = Color.LightGray;
            btnUpdate.Location = new Point(((Width / 2) - (btnUpdate.Width / 2)), (Height - 100));

            // Add the button to the form
            Controls.Add(btnUpdate);

            // Install various events using the default delegate 'EventHandler'.
            btnUpdate.Click += new EventHandler(BtnUpdate_Click);
            btnUpdate.MouseEnter += new EventHandler(BtnUpdate_MouseEnter);
            btnUpdate.MouseLeave += new EventHandler(BtnUpdate_MouseLeave);
            myDateLabel.MouseEnter += new EventHandler(MyDataLabel_MouseEnter);
            myDateLabel.MouseLeave += new EventHandler(MyDataLabel_MouseLeave);

            // Create an Ok button.
            btnOk = new Button();
            btnOk.Text = "Ok";
            btnOk.Click += new EventHandler(BtnOk_Click);
            btnOk.Top = btnUpdate.Top + btnUpdate.Height + 10;
            btnOk.Left = btnUpdate.Left;
            btnOk.BackColor = Color.LightGray;
            AcceptButton = btnOk;

            // Add the Ok button to the form.
            Controls.Add(btnOk);
        }


        // Event handlers
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            DateTime currDate = DateTime.Now;
            myDateLabel.Text = currDate.ToString();
        }

        protected void BtnUpdate_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.HotPink;
        }

        protected void BtnUpdate_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        protected void MyDataLabel_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        protected void MyDataLabel_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            // Inform all message pumps to terminate ...
            // Close the form.
            Application.Exit();
        }


        // Main method
        public static void Main(string[] args)
        {
            // Run the application and make the form visible.
            Application.Run(new ButtonApp());            
        }
    }
}
