using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjTwitchBotVisual
{
    public partial class frmModSelection : Form
    {
        public frmModSelection()
        {
            InitializeComponent();
        }

        private void btnAddMod_Click(object sender, EventArgs e)
        {
            string sql = txtModName.Text;
            
            try
            {
                sql = "insert into streamMods (name) values ('" + txtModName.Text + "')";
                FileReaderWriter.ExecuteCommand(FileReaderWriter.databaseConnection(), sql);
                frmModSelection.ActiveForm.Close();
            }
            catch(System.Data.SQLite.SQLiteException)
            {
                MessageBox.Show("The SQL database has encountered an error, please try again");
            }
        }


    }
}
