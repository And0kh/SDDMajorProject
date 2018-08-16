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

                switch (slctedOptn){//Makes the appropriate events details panel visible
                    case "Swimming carnival":
                        pnlEvnt.Visible = false;
                        pnlSwmng.Visible = true;
                        pnlSwmng.Location = new Point(12, 12);
                        break;
                    case "Athletics carnival":
                        pnlEvnt.Visible = false;
                        pnlAthltcs.Visible = true;
                        pnlAthltcs.Location = new Point(12, 12);
                        break;
                    case "Cross country":
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
            }
        }
    }
}
