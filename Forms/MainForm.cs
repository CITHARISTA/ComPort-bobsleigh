using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPort.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonSportsman_Click(object sender, EventArgs e)
        {
            Hide();
            var sportsmanForm = ContainerService.GetInject<SportsmanForm>();
            sportsmanForm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
            var sportsmanForm = ContainerService.GetInject<MeasurementForm>();
            sportsmanForm.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Hide();
            var sportsmanForm = ContainerService.GetInject<CalculationForm>();
            sportsmanForm.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Hide();
            var sportsmanForm = ContainerService.GetInject<ResultForm>();
            sportsmanForm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Hide();
            var sportsmanForm = ContainerService.GetInject<BeanForm>();
            sportsmanForm.Show();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Hide();
            var settingsForm = ContainerService.GetInject<SettingsForm>();
            settingsForm.Show();
        }

        private void ButFakt_Click(object sender, EventArgs e)
        {
            Hide();
            var faktForm = ContainerService.GetInject<FaktForm>();
            faktForm.Show();
        }

        private void ButResFukt_Click(object sender, EventArgs e)
        {
            Hide();
            var faktResultForm = ContainerService.GetInject<FaktResultForm>();
            faktResultForm.Show();
        }
    }
}
