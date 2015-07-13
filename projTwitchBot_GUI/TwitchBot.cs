using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace projTwitchBotVisual
{
    public partial class frmTwitchBot : Form
    {
        int frmState = 1;
        public frmTwitchBot()
        {
            InitializeComponent();
            comboConnection.SelectedIndex = 1;
        }

        private void btnServerConnection_Click(object sender, EventArgs e)
        {
            string buf;
            System.IO.TextReader input;
            System.IO.TextWriter output;

            Connection b = new Connection();
            TcpClient sock = b.Con(Convert.ToInt32(txtPort.Text), txtServer.Text);
            input = new StreamReader(sock.GetStream());
            output = new StreamWriter(sock.GetStream());
            output.Write("PASS " + (txtOuth.Text) + "\r\n" + "NICK " + txtNick.Text + "\r\n");
            output.Flush();

            WinConsole a = new WinConsole();
            a.Main();
            this.Visible = false;
            for (buf = input.ReadLine(); ; buf = input.ReadLine())
            {
                //Display received irc message
                Console.WriteLine(buf);
                StreamCommands delta = new StreamCommands();
                delta.PingPong(buf, output);
                delta.Ding(buf);
                delta.Dong(buf);
                delta.addCommand(buf);

                if (buf[0] != ':') continue;

                /* IRC commands come in one of these formats:
                 * :NICK!USER@HOST COMMAND ARGS ... :DATA\r\n
                 * :SERVER COMAND ARGS ... :DATA\r\n
                 */

                //After server sends 001 command, we can set mode to bot and join a channel
                if (buf.Split(' ')[1] == "001")
                {
                    output.Write(
                        "MODE " + txtNick.Text + " +B\r\n" +
                        "JOIN " + txtChan.Text + "\r\n"
                    );
                    output.Flush();
                }
            }
        }


        private void comboConnection_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboConnection.SelectedIndex){
                case 0: menuLayoutTwitch();
                        break;
                case 1: menuLayoutOther();
                        break;
                default: Console.Write("pick something else");
                        break;
            }
        }

        public void menuLayoutTwitch()
        {
            System.Drawing.Point chan = lblChannel.Location;
            System.Drawing.Point chanTxt = txtChan.Location; 

            lblPortNumber.Visible = false;
            lblChannel.Location = lblServer.Location;
            txtChan.Location = txtServer.Location;
            lblServer.Location = chan;
            txtServer.Location = chanTxt;
            lblServer.Visible = false;
            txtPort.Visible = false;
            txtPort.Text = "6667";
            txtServer.Visible = false;
            txtServer.Text = "irc.twitch.tv";
            lblOuthKey.Visible = true;
            txtOuth.Visible = true;
            if (frmState == 1) { frmState = 0; }
            Refresh();
        }

        public void menuLayoutOther()
        {
            if (frmState == 0)
            {
                System.Drawing.Point chan = lblChannel.Location;
                System.Drawing.Point chanTxt = txtChan.Location;

                lblChannel.Location = lblServer.Location;
                txtChan.Location = txtServer.Location;
                lblServer.Location = chan;
                txtServer.Location = chanTxt;
                
                frmState = 1;
            }

            lblPortNumber.Visible = true;
            lblServer.Visible = true;
            lblBotName.Visible = true;
            lblChannel.Visible = true;
            txtChan.Visible = true;
            txtNick.Visible = true;
            txtPort.Visible = true;
            txtPort.Clear();
            txtServer.Visible = true;
            txtServer.Clear();
            lblOuthKey.Visible = false;
            txtOuth.Visible = false;
            txtOuth.Clear();
            Refresh();
        }

        private void viewCommandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addCommandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open another class and read from a text file display to user
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "Connection Data File|*.cdf";
            SFD.Title = "Save a text File";
            SFD.ShowDialog();

            FileReaderWriter.ConWriter(Convert.ToInt32(txtPort.Text), txtNick.Text, txtServer.Text, txtChan.Text, SFD.FileName);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] conData = new String[4];
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Connection Data File|*.cdf";
            OFD.Title = "Open Connection File";
            OFD.ShowDialog();
            
            conData = FileReaderWriter.reader(OFD.FileName);

            txtNick.Text = conData[0];
            txtServer.Text = conData[1];
            txtPort.Text = conData[2];
            txtChan.Text = conData[3];

        }
    }
}
