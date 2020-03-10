using ComPort.Models;
using ComPort.Repositories.Json.Interfaces;
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
    public partial class ResultForm : Form
    {
        private readonly IIOResult _iOData;
        private MainForm _mainForm;
        private List<Result> Results { get; set; }

        public ResultForm(MainForm form, IIOResult iOResult)
        {
            InitializeComponent();
            _mainForm = form;
            _iOData = iOResult;
            Results = _iOData.GetData();
            Results.Reverse();
            InitNames();
        }

        private void InitNames()
        {
            Names.Items.Clear();
            foreach (var result in Results)
            {
                Names.Items.Add(result.Name + "   " + result.DateTime);
            }
        }

        private void Names_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearInputs();
            InitInputs();
        }

        private void ClearInputs()
        {
            Weight.Text = string.Empty;
            dateTime.Text = string.Empty;
            RequiredLoad.Text = string.Empty;
            WeightLoad.Text = string.Empty;
            FP.Text = string.Empty;
            PosLoad.Text = string.Empty;
            RP.Text = string.Empty;
            Pilot.Text = string.Empty;
            Razgon1.Text = string.Empty;
            Razgon2.Text = string.Empty;
            Razgon3.Text = string.Empty;
        }

        private void InitInputs()
        {
            if (Names.SelectedIndex > -1)
            {
                var result = Results[Names.SelectedIndex];
                Weight.Text = result.Weight.ToString();
                WeightLoad.Text = result.WeightLoad.ToString();
                FP.Text = result.FP.ToString();
                PosLoad.Text = result.PosLoad.ToString();
                RP.Text = result.RP.ToString();
                Pilot.Text = result.Pilot;
                Razgon1.Text = result.Razgon1;
                Razgon2.Text = result.Razgon2;
                Razgon3.Text = result.Razgon3;
                dateTime.Text = result.DateTime.ToString();
                RequiredLoad.Text = result.RequiredLoad.ToString();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Names.SelectedIndex > -1)
            {
                Results.RemoveAt(Names.SelectedIndex);
                _iOData.SaveData(Results);
                ClearInputs();
                InitNames();
            }
            else
            {
                MessageBox.Show("Нужно выбрать название расчета", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            Close();
        }

    }
}
