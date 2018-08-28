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
                    athltcsDistanceAtmt1UpDn.Visible = false;
                    athltcsDistanceAtmt2UpDn.Visible = false;
                    athltcsDistanceAtmt3UpDn.Visible = false;
                    lblTm.Visible = true;
                    lblAthltcsMinutes.Visible = true;
                    lblAthltcsScndsMilli.Visible = true;
                    athltcsTmMUpDn.Visible = true;
                    athltcsTmScMilliUpDn.Visible = true;

                    lblDstnc.Visible = false;
                    athltcsDistanceAtmt1UpDn.Visible = false;
                    break;
                case "High jump":
                case "Long jump":
                case "Shot put":
                case "Javelin":
                case "Discus":
                    lblDstnc.Visible = true;
                    athltcsDistanceAtmt1UpDn.Visible = true;
                    athltcsDistanceAtmt2UpDn.Visible = true;
                    athltcsDistanceAtmt3UpDn.Visible = true;

                    lblTm.Visible = false;
                    lblAthltcsMinutes.Visible = false;
                    lblAthltcsScndsMilli.Visible = false;
                    athltcsTmMUpDn.Visible = false;
                    athltcsTmScMilliUpDn.Visible = false;
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

                this.MinimumSize = new Size(700, 300);//Help from https://stackoverflow.com/a/5314065

                switch (slctedOptn){//Makes the appropriate events details panel visible
                    case "Swimming carnival":
                        pnlEvnt.Visible = false;
                        pnlSwmng.Visible = true;
                        pnlSwmng.Location = new Point(5, this.Height/2- pnlSwmng.Height/2 - 20);
                        break;
                    case "Athletics carnival":
                        pnlEvnt.Visible = false;
                        pnlAthltcs.Visible = true;
                        pnlAthltcs.Location = new Point(5, this.Height/2 - pnlAthltcs.Height/2 - 20);
                        lblTm.Location = new Point(13, 156);
                        lblAthltcsMinutes.Location = new Point(79, 129);
                        lblAthltcsScndsMilli.Location = new Point(171, 129);
                        athltcsTmMUpDn.Location = new Point(88, 156);
                        athltcsTmScMilliUpDn.Location = new Point(182, 156);
                        break;
                    case "Cross country":
                        pnlEvnt.Visible = false;
                        pnlCrsCntry.Visible = true;
                        pnlCrsCntry.Location = new Point(5, this.Height/2 - pnlCrsCntry.Height/2 - 20);
                        break;
                    default:
                        break;
                }

                listViewEnteredData.Location = new Point(300, this.Height / 2 - listViewEnteredData.Height / 2 - 30);
                listViewEnteredData.Visible = true;
                btnRemoveEntry.Location = new Point(300, this.Height / 2 + 75);
                btnRemoveEntry.Visible = true;
                btnSort.Location = new Point(365, this.Height / 2 + 75);
                btnSort.Visible = true;
                cmboBxAgeSort.Location = new Point(430, this.Height / 2 + 72);
                cmboBxAgeSort.Visible = true;
                cmboBxEventSort.Location = new Point(490, this.Height / 2 + 72);
                cmboBxEventSort.Visible = true;
            }
            else{
                MessageBox.Show("Please select an event");
            }
        }

        private void DataEnter(object sender, EventArgs e){
            var b = sender as Button;//Help from https://stackoverflow.com/a/25893605
            switch (b.Name){

                case "btnSwmEntr":
                    if (!string.IsNullOrWhiteSpace(txtBxSwmSdntName.Text) && cmboBxSwmBxAge.Text != "" && cmboBxSwmEvnts.Text != "" && cmboBxSwmDstnc.Text != ""){//Check to see if a name is entered
                        //Getting the time entered
                        int minutes = Convert.ToInt32(swmTmMinUpDn.Value.ToString());
                        decimal seconds = Convert.ToDecimal(swmTmScMilliUpDn.Value.ToString());
                        decimal time = minutes * 60 + seconds;

                        if (time != 0){
                            //               Name                    Age                  Event               Result
                            string[] row = { txtBxSwmSdntName.Text, cmboBxSwmBxAge.Text, cmboBxSwmEvnts.Text, minutes.ToString()+" m "+ seconds.ToString()+" sec" };
                            var listViewItem = new ListViewItem(row);
                            listViewEnteredData.Items.Add(listViewItem);
                        }else{ MessageBox.Show("Please enter a time."); }
                    }
                    else {
                        MessageBox.Show("Please enter a name, age, event or distance.");
                    }
                    break;

                case "btnCrsCntryEntr":
                    if (!string.IsNullOrWhiteSpace(txtBxCrsCntrySdntName.Text) && cmboBxCrsCntryBxAge.Text != ""){//Checks to se is a name is entered

                        int minutes = Convert.ToInt32(crsCntryTmMinUpDn.Value.ToString());
                        decimal seconds = Convert.ToDecimal(crsCntryTmScMilliUpDn.Value.ToString());
                        decimal time = minutes * 60 + seconds;

                        if (time != 0) {
                            //               Name                        Age                       Event            Result
                            string[] row = { txtBxCrsCntrySdntName.Text, cmboBxCrsCntryBxAge.Text, "Cross country", minutes.ToString() + " m " + seconds.ToString() + " sec" };
                            var listViewItem = new ListViewItem(row);
                            listViewEnteredData.Items.Add(listViewItem);
                        } else { MessageBox.Show("Please enter a time"); }
                    }else { MessageBox.Show("Please enter the name or age of the student."); }
                    break;

                case "btnAthltcsEntr":
                    if (!string.IsNullOrWhiteSpace(txtBxAthltcsSdntName.Text) && cmboBxAthltcsBxAge.Text != "") {//Checks to see if a name is entered

                        int minutes = Convert.ToInt32(athltcsTmMUpDn.Value.ToString());
                        decimal seconds = Convert.ToDecimal(athltcsTmScMilliUpDn.Value.ToString());
                        decimal time = minutes * 60 + seconds;


                        switch (cmboBxAthltcsEvnts.Text) {
                            case "Running 100m":
                            case "Running 200m":
                            case "Running 400m":
                            case "Running 800m":
                            case "Running 1500m":
                                if (time != 0) {
                                    //               Name                       Age                      Event                    Result
                                    string[] row = { txtBxAthltcsSdntName.Text, cmboBxAthltcsBxAge.Text, cmboBxAthltcsEvnts.Text, minutes.ToString() + " m " + seconds.ToString() + " sec" };
                                    var listViewItem = new ListViewItem(row);
                                    listViewEnteredData.Items.Add(listViewItem);
                                } else { MessageBox.Show("Please enter a time."); }
                                break;
                            case "High jump":
                            case "Long jump":
                            case "Shot put":
                            case "Javelin":
                            case "Discus":
                                if (athltcsDistanceAtmt1UpDn.ToString() != "0") {
                                    //               Name                       Age                      Event                    Result
                                    string[] row = { txtBxAthltcsSdntName.Text, cmboBxAthltcsBxAge.Text, cmboBxAthltcsEvnts.Text, (athltcsDistanceAtmt1UpDn.Value.ToString()+" m, "+athltcsDistanceAtmt2UpDn.Value.ToString()+" m, "+athltcsDistanceAtmt3UpDn.Value.ToString()+" m") };
                                    var listViewItem = new ListViewItem(row);
                                    listViewEnteredData.Items.Add(listViewItem);
                                }
                                break;
                        }
                    } else { MessageBox.Show("Please enter a name, age, ."); }
                    break;

                default:
                    break;
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

        private void btnRemoveEntry_Click(object sender, EventArgs e){//Will remove the selected data entry
            if (listViewEnteredData.Items.Count > 0) {
                listViewEnteredData.Items.Remove(listViewEnteredData.SelectedItems[0]);
            } else { MessageBox.Show("No items to remove."); }
        }

        private void btnSort_Click(object sender, EventArgs e){

        }
    }
}
