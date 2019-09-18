using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoeTree
{

    public partial class PoeTreeMain : Form
    {

        /*########### UI ELEMENTS ############
         * private Label titleLbl; -- The program's title.
         * private TextField usernameTxt; -- The name the user enters.
         * private Button usernameConfirmButton; -- Button to confirm user's name.
         * private Label welcomeUserLbl; -- Label to display a welcome message to user.
        */

        //########### UI Attributes ############
        private const String PROG_TITLE = "PoeTree"; //Title of the program PoeTree - a Poetry app.
        private const String BTN_CONFIRM_MESSAGE = "Confirm";
        private const String LBL_WELCOME_MESSAGE = ", hello and welcome to PoeTree!";

        public PoeTreeMain()
        {
            InitializeComponent();
        }

        private void PoeTreeMain_Load(object sender, EventArgs e)
        {
            InitialiseUI();
        }

        /*
         *Initialises the UI to display the correct values to the user upon startup. 
         */
        private void InitialiseUI()
        {
            titleLbl.Text = PROG_TITLE;
            usernameConfirmButton.Text = BTN_CONFIRM_MESSAGE;
            welcomeUserLbl.Text = "";
        }

        /*
         *Updates the welcome message to display the username previously entered. 
         */
        private void usernameConfirmButton_Click(object sender, EventArgs e)
        {
            welcomeUserLbl.Text = usernameTxt.Text + LBL_WELCOME_MESSAGE;
        }
    }
}
