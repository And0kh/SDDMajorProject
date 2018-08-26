using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDDMajorProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            pnlEvnt.Location = new Point(this.Width / 2 - pnlEvnt.Width/2, this.Height / 2 - pnlEvnt.Height/2);
        }

        //If "Other" is selected, make the text visible, otherwise make is invisible
        private void isOthrSlctd(object sender, System.EventArgs e){
            string slctdOptn = (cmboBxEvnt.SelectedItem).ToString();/*Assigning to slctdOptn the selected option if the combo box
            https://stackoverflow.com/a/18830040 */
            if (slctdOptn == "Other (enter below)"){
                txtBxOthr.Visible = true;
            }
            else{
                txtBxOthr.Visible = false;
            }
        }

        private void TimeOrDistance(object sender, EventArgs e){
            string slctdOptn = (cmboBxAthltcsEvnts.SelectedItem).ToString();
            switch (slctdOptn){
                case "Running 100m":
                case "Running 200m":
                case "Running 400m":
                case "Running 800m":
                case "Running 1500m":
                    lblTm.Text = "Time";
                    nmrcUpDnAtmpt.Enabled = false;
                    break;
                case "High jump":
                case "Long jump":
                case "Shot put":
                case "Javelin":
                case "Discus":
                    lblTm.Text = "Distance";
                    nmrcUpDnAtmpt.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        //Upon clicking the "Confirm" button, the panels change.
        private void btnCnfm_Click(object sender, EventArgs e){
            string slctedOptn;
            //string events;
            if (cmboBxEvnt.SelectedItem != null){
                //Assigns the name of the selected option in the combp box to a string
                slctedOptn = cmboBxEvnt.SelectedItem.ToString();

                //Load the file for the selected event by using the FileHandler class
                FileHandler.Read(slctedOptn);
                foreach (string evnt in FileHandler.FlText){//Fix this for "other" type 
                    ChangeEvents(evnt, slctedOptn);
                }

                this.MinimumSize = new Size(320, 250);//Help from https://stackoverflow.com/a/5314065

                switch (slctedOptn){//Makes the appropriate events details panel visible
                    case "Swimming carnival":
                        pnlEvnt.Visible = false;
                        pnlSwmng.Visible = true;
                        pnlSwmng.Location = new Point(this.Width / 2 - pnlSwmng.Width/2, this.Height / 2 - pnlSwmng.Height/2 - 20);
                        break;
                    case "Athletics carnival":
                        pnlEvnt.Visible = false;
                        pnlAthltcs.Visible = true;
                        pnlAthltcs.Location = new Point(this.Width / 2 - pnlAthltcs.Width / 2, this.Height / 2 - pnlAthltcs.Height / 2 - 20);
                        break;
                    case "Cross country":
                        pnlEvnt.Visible = false;
                        pnlCrsCntry.Visible = true;
                        pnlCrsCntry.Location = new Point(this.Width / 2 - pnlAthltcs.Width / 2, this.Height / 2 - pnlAthltcs.Height / 2 - 20);
                        break;
                    default:
                        break;
                }
            }
            else{
                MessageBox.Show("Please select an event");
            }
        }

        public void ChangeEvents(string events, string slctedOptn){
            switch (slctedOptn){
                case "Swimming carnival":
                    cmboBxSwmEvnts.Items.Add(events);
                    break;
                case "Athletics carnival":
                    cmboBxAthltcsEvnts.Items.Add(events);
                    break;
                case "Cross country":
                    break;
                default:
                    break;
            }
        }
    }
}
