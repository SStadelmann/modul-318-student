using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace WindowsFormsApp2
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();

            dtptime.Format = DateTimePickerFormat.Custom;
            dtptime.CustomFormat = "HH:mm";
            dtptime.ShowUpDown = true;
            dtpdate.Format = DateTimePickerFormat.Custom;
            dtpdate.CustomFormat = "dd/MM/yyyy";


            // Umgestaltung der Buttons
            btnVerb.FlatStyle = FlatStyle.Flat;
            btnVerb.FlatAppearance.BorderSize = 0;
            btnswitch.FlatStyle = FlatStyle.Flat;
            btnswitch.FlatAppearance.BorderSize = 0;
            btnoptions.FlatStyle = FlatStyle.Flat;
            btnoptions.FlatAppearance.BorderSize = 0;

            //Hintergrundfarbe des Forms
            BackColor = Color.FromArgb(240, 240, 240);

            // Hintergrundfarben der Labels
            titel.BackColor = Color.FromArgb(240, 240, 240);
            from.BackColor = Color.FromArgb(240, 240, 240);
            to.BackColor = Color.FromArgb(240, 240, 240);
            time.BackColor = Color.FromArgb(240, 240, 240);
            label6.BackColor = Color.FromArgb(240, 240, 240);
            label7.BackColor = Color.FromArgb(240, 240, 240);

            // Vordergrundfarben der Labels
            titel.ForeColor = Color.Red;
            from.ForeColor = Color.Black;
            to.ForeColor = Color.Black;
            time.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;

            // Hintergrundfarben der Buttons
            btnswitch.BackColor = Color.FromArgb(240, 240, 240);
            btnVerb.BackColor = Color.Red;
            btnoptions.BackColor = Color.FromArgb(240, 240, 240);

            // Vordergrundfarben der Buttons
            btnswitch.ForeColor = Color.Red;
            btnVerb.ForeColor = Color.White;

            // Hintergrundfarben der Textboxen
            tbxfrom.BackColor = Color.White;
            tbxto.BackColor = Color.White;
            dtptime.BackColor = Color.White;
            dtpdate.BackColor = Color.White;

            // Vordergrundfarben der Textboxen
            tbxfrom.ForeColor = Color.Black;
            tbxto.ForeColor = Color.Black;
            dtptime.ForeColor = Color.Black;
            dtpdate.ForeColor = Color.Black;


        }

        // Objekte
        SwissTransport.Transport Transport = new SwissTransport.Transport();
        SwissTransport.Connections Connections = new SwissTransport.Connections();
        SwissTransport.StationBoardRoot StationBoard = new SwissTransport.StationBoardRoot();
        SwissTransport.Stations Stations = new SwissTransport.Stations();
        SwissTransport.Station SelectedStartStation = new SwissTransport.Station();
        SwissTransport.Station SelectedDestinationStation = new SwissTransport.Station();

        // string für "Einstellungen"
        string options = "Möchten Sie Darkmode?";
       private new void Update()
        {
            dgrhide.DataSource = null;
            if (SelectedStartStation.Name != null && SelectedDestinationStation.Name != null)
            {
                Connections = Transport.GetConnections(SelectedStartStation.Name, SelectedDestinationStation.Name, DateTime.Now, DateTime.Now);
                if (Connections != null)
                    dgrhide.DataSource = Connections.ConnectionList;
                else
                {
                    MessageBox.Show("Keine Verbindungen gefunden");
                    return;
                }
                try
                {
                    dgrhide.Columns.Remove("Von");
                    dgrhide.Columns.Remove("Nach");
                }
                catch
                {
                    MessageBox.Show("Es wurde ein Fehler gefunden");
                }
            }
            else
            {
                if (SelectedStartStation.Name != null)
                {
                    StationBoard = Transport.GetStationBoard(SelectedStartStation.Name, SelectedStartStation.Id);
                }
                else
                {
                    StationBoard = Transport.GetStationBoard(SelectedDestinationStation.Name, SelectedDestinationStation.Id);
                }
                if (StationBoard != null)
                    dgrhide.DataSource = StationBoard.Entries;
                else
                {
                    MessageBox.Show("Keinen Fahrplan gefunden");
                    return;
                }
                try
                {
                    dgrhide.Columns.Remove("Name");
                    dgrhide.Columns.Remove("Category");
                    dgrhide.Columns.Remove("Operator");
                }
                catch
                {
                    MessageBox.Show("Es wurde ein Fehler gefunden");
                }
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            // Wechseln der Hintergrundfarbe
            Control control = lblfrom.Parent;
            Form myForm = lblfrom.FindForm();
            lblfrom.BackColor = Color.LightGray;
            lblto.BackColor = Color.Transparent;
        }


        private void Label2_Click(object sender, EventArgs e)
        {
            // Wechseln der Hintergrundfarbe
            Control control = lblto.Parent;
            Form myForm = lblto.FindForm();
            lblto.BackColor = Color.LightGray;
            lblfrom.BackColor = Color.Transparent;
        }

        private void BtnVerb_Click(object sender, EventArgs e)
        {
            dgrhide.Visible = true;
        }

        private void Btnswitch_Click(object sender, EventArgs e)
        {
            // Inhalt der Textboxen tauschen mit einem temporären string
            string temp;
            temp = tbxto.Text;
            tbxto.Text = tbxfrom.Text;
            tbxfrom.Text = temp;
        }



        // Start Destination

        private void Tbxfrom_TextChanged(object sender, EventArgs e)
        {

            {
                var textBox = new TextBox();


                lbxdisplay1.Show();
                Stations = Transport.GetStations(tbxfrom.Text);
                lbxdisplay1.DataSource = Stations.StationList;
                lbxdisplay1.DisplayMember = "Name";

            }
        }

        private void Tbxfrom_MouseDown(object sender, MouseEventArgs e)
        {
            Stations = Transport.GetStations(tbxfrom.Text);
            lbxdisplay1.DataSource = Stations.StationList;
            lbxdisplay1.DisplayMember = "Name";
            if (lbxdisplay1.Items.Count == 0)
            {
                lbxdisplay1.Hide();
            }
        }

        private void Tbxfrom_Enter(object sender, EventArgs e)
        {
            lbxdisplay1.Show();
        }

        private void LbxAnzeige_MouseDown(object sender, MouseEventArgs e)
        {
            SelectedStartStation = (SwissTransport.Station)lbxdisplay1.SelectedItem;
            tbxfrom.Text = SelectedStartStation.Name;
            lbxdisplay1.Hide();
            Update();
        }

        private void Tbxfrom_Leave(object sender, EventArgs e)
        {

        }



        // End Destination

        private void Tbxto_TextChanged(object sender, EventArgs e)
        {
            var textBox = new TextBox();


            lbxdisplay2.Show();
            Stations = Transport.GetStations(tbxto.Text);
            lbxdisplay2.DataSource = Stations.StationList;
            lbxdisplay2.DisplayMember = "Name";
        }

        private void Tbxto_MouseDown(object sender, MouseEventArgs e)
        {
            Stations = Transport.GetStations(tbxto.Text);
            lbxdisplay2.DataSource = Stations.StationList;
            lbxdisplay2.DisplayMember = "Name";
            if (lbxdisplay2.Items.Count == 0)
            {
                lbxdisplay2.Hide();
            }
        }

        private void Tbxto_Enter(object sender, EventArgs e)
        {
            lbxdisplay2.Show();
        }

        private void Lbxdisplay2_MouseDown(object sender, MouseEventArgs e)
        {
            SelectedDestinationStation = (SwissTransport.Station)lbxdisplay2.SelectedItem;
            tbxto.Text = SelectedDestinationStation.Name;
            lbxdisplay2.Hide();
            Update();

        }

        private void Tbxto_Leave(object sender, EventArgs e)
        {

        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            lbxdisplay1.Hide();
            lbxdisplay2.Hide();
        }



        // "Einstellungen" Button

        private void Btnoptions_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(options, "Einstellungen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Darkmode settings (selbe Gliederung wie start)
                BackColor = Color.FromArgb(64, 59, 59);

                titel.BackColor = Color.FromArgb(64, 59, 59);
                from.BackColor = Color.FromArgb(64, 59, 59);
                to.BackColor = Color.FromArgb(64, 59, 59);
                time.BackColor = Color.FromArgb(64, 59, 59);
                label6.BackColor = Color.FromArgb(64, 59, 59);
                label7.BackColor = Color.FromArgb(64, 59, 59);

                titel.ForeColor = Color.FromArgb(77, 255, 213);
                from.ForeColor = Color.White;
                to.ForeColor = Color.White;
                time.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;

                btnswitch.BackColor = Color.FromArgb(64, 59, 59);
                btnVerb.BackColor = Color.FromArgb(77, 255, 213);
                btnoptions.BackColor = Color.FromArgb(64, 59, 59);

                btnswitch.ForeColor = Color.FromArgb(77, 255, 213);
                btnVerb.ForeColor = Color.FromArgb(64, 59, 59);

                tbxfrom.BackColor = Color.FromArgb(96, 94, 99);
                tbxto.BackColor = Color.FromArgb(96, 94, 99);
                dtptime.BackColor = Color.FromArgb(96, 94, 99);
                dtpdate.BackColor = Color.FromArgb(96, 94, 99);

                tbxfrom.ForeColor = Color.White;
                tbxto.ForeColor = Color.White;
                dtptime.ForeColor = Color.White;
                dtpdate.ForeColor = Color.White;
            }
            else
            {
                // "normaler" mode settings (selbe Gliederung wie start)
                BackColor = Color.FromArgb(240, 240, 240);

                titel.BackColor = Color.FromArgb(240, 240, 240);
                from.BackColor = Color.FromArgb(240, 240, 240);
                to.BackColor = Color.FromArgb(240, 240, 240);
                time.BackColor = Color.FromArgb(240, 240, 240);
                label6.BackColor = Color.FromArgb(240, 240, 240);
                label7.BackColor = Color.FromArgb(240, 240, 240);

                titel.ForeColor = Color.Red;
                from.ForeColor = Color.Black;
                to.ForeColor = Color.Black;
                time.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;

                btnswitch.BackColor = Color.FromArgb(240, 240, 240);
                btnVerb.BackColor = Color.Red;

                btnswitch.ForeColor = Color.Red;
                btnVerb.ForeColor = Color.White;
                btnoptions.BackColor = Color.FromArgb(240, 240, 240);

                tbxfrom.BackColor = Color.White;
                tbxto.BackColor = Color.White;
                dtptime.BackColor = Color.White;
                dtpdate.BackColor = Color.White;

                tbxfrom.ForeColor = Color.Black;
                tbxto.ForeColor = Color.Black;
                dtptime.ForeColor = Color.Black;
                dtpdate.ForeColor = Color.Black;
            }

        }

        private void Lbxdisplay1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Mtbxdate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Dgrhide_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}


