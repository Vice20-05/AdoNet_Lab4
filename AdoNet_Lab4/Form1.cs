using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;



namespace AdoNet_Lab4
{
    public partial class Form1 : Form
    {

        // SQLite helper instance using a local file database
        private SQLiteHandler db = new SQLiteHandler("Data Source=keywords.db");
        public Form1()
        {
            // Initialize Windows Forms components
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //add a keyword to the database
        private void addKeywordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ensure there is an open connection before attempting insert
            if(!db.IsConnected())
            {
                MessageBox.Show("Please connect to the database first.");
                return;
            }

            // Insert a test keyword (replace with user input in a real app)
            db.InsertKeyword("test");

            // Inform the user that the insert was requested
            MessageBox.Show("Add Keyword clicked");
        }


        //connect to the database and create the table if it does not exist
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the SQLite connection and ensure the keywords table exists
            db.ConnectToDB();

            // Notify the user the connection has been opened
            MessageBox.Show("Connected to the database.");
        }


        //disconnect from the database
        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the SQLite connection when the user requests disconnect
            db.DisconnectFromDB();

            // Notify the user the connection has been closed
            MessageBox.Show("Disconnected from the database.");
        }



        //About the application
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show a short description of the application
            MessageBox.Show("This is a simple ADO.NET application that connects to a SQLite database and allows you to add keywords to the database.");
        }

        private void viewKeywordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verify connection before attempting to read
            if(!db.IsConnected())
            {
                MessageBox.Show("Please connect to the database first.");
                return;
            }

            // Retrieve all keywords from the database
            List<string> keywords = db.GetAllKeywords();

            // Show a friendly message if no keywords exist
            if(keywords.Count == 0)
            {
                MessageBox.Show("No keywords found in the database.");
                return;
            }
            else
            {
                // Display all keywords joined by newlines
                MessageBox.Show("Keywords in the database:\n" + string.Join("\n", keywords));
            }

            
        }
    }
}
