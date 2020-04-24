using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch != null)
            {
                if (toggleSwitch.IsOn == true)
                {
                    progress1.IsActive = true;
                    progress1.Visibility = Visibility.Visible;
                }
                else
                {
                    progress1.IsActive = false;
                    progress1.Visibility = Visibility.Collapsed;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSwitch lightToggle = new ToggleSwitch();
            lightToggle.Header = "An";

            // Add the toggle switch to a parent container in the visual tree.
            stackPanel1.Children.Add(lightToggle);

            // Create a new toggle switch and add a Toggled event handler.
            ToggleSwitch toggleSwitch1 = new ToggleSwitch();
            toggleSwitch1.Toggled += ToggleSwitch_Toggled;

            // Add the toggle switch to a parent container in the visual tree.
            stackPanel1.Children.Add(toggleSwitch1);
        }
    }
}
