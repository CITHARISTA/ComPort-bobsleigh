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
    public partial class FaktResultForm : Form
    {
        private readonly MainForm _mainForm;
        private readonly IIOFaktResult _iOData;
        private List<FaktResult> Results { get; set; }
        public FaktResultForm(MainForm mainForm, IIOFaktResult iOFaktResult)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _iOData = iOFaktResult;
            Results = _iOData.GetData();
            Results.Reverse();
            InitNames();
        }

        private void InitNames()
        {
            Names.Items.Clear();
            foreach (var result in Results)
            {
                Names.Items.Add(result.Name + "   " + result.Date);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            Close();
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
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            Gender.Text = string.Empty;
            TeamBox.Text = string.Empty;
            TypeBox.Text = string.Empty;
            NameMeas.Text = string.Empty;
            DistanceExis.Text = string.Empty;
        }

        private void InitInputs()
        {
            if (Names.SelectedIndex > -1)
            {
                var result = Results[Names.SelectedIndex];
                Weight.Text = result.Weight.ToString();
                WeightLoad.Text = result.WeightGruz.ToString();
                FP.Text = result.WeightF_P.ToString();
                PosLoad.Text = result.DistanceGruz.ToString();
                RP.Text = result.WeightB_P.ToString();
                dateTime.Text = result.Date.ToString();
                RequiredLoad.Text = result.Required.ToString();
                textBox1.Text = result.WeightF.ToString();
                textBox2.Text = result.WeightB.ToString();

                NameMeas.Text = result.Name.ToString();
                Gender.Text = result.Gender.ToString();
                TypeBox.Text = result.Type.ToString();
                DistanceExis.Text = result.DistanceExis.ToString();
                TeamBox.Text = result.Team.ToString();
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
    }
}
