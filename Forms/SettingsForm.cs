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
    public partial class SettingsForm : Form
    {
        private readonly IIOSettings _iOData;
        private Settings _settings;
        private MainForm _mainForm;
        private List<TextBox> textBoxes;
        public SettingsForm(MainForm mainForm, IIOSettings iOSettings)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _iOData = iOSettings;
            _settings = _iOData.GetData();
            textBoxes = new List<TextBox> { textBox1, textBox2, textBox3, AcceleratingBox1,
                AcceleratingBox2, AcceleratingBox3, PilotBox, PilotLegs, textBox4, textBox5, textBox6 };
            InitInputs();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (TextBoxesIsNotEmpty())
            {
                try
                {
                    var settings = GetDataFromInputs();
                    _iOData.SaveData(settings);
                    MessageBox.Show("Данные успешно сохранены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Некорректные данные!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Некоторые пункты пустые!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            Close();
        }

        private bool TextBoxesIsNotEmpty() => !textBoxes.Any(x => string.IsNullOrEmpty(x.Text));

        private Settings GetDataFromInputs() => new Settings
        {
            WeightM_4 = Convert.ToDouble(textBox1.Text),
            WeightM_2 = Convert.ToDouble(textBox2.Text),
            WeightW_2 = Convert.ToDouble(textBox3.Text),
            PilotLegs_4 = Convert.ToDouble(PilotLegs.Text),
            Pilot_4 = Convert.ToDouble(PilotBox.Text),
            Razgon1_4 = Convert.ToDouble(AcceleratingBox1.Text),
            Razgon2_4 = Convert.ToDouble(AcceleratingBox2.Text),
            Razgon3_4 = Convert.ToDouble(AcceleratingBox3.Text),
            PilotLegs_2 = Convert.ToDouble(textBox4.Text),
            Pilot_2 = Convert.ToDouble(textBox5.Text),
            Razgon1_2 = Convert.ToDouble(textBox6.Text)
        };

        private void InitInputs()
        {
            textBox1.Text = _settings.WeightM_4.ToString("F0");
            textBox2.Text = _settings.WeightM_2.ToString("F0");
            textBox3.Text = _settings.WeightW_2.ToString("F0");
            textBox4.Text = _settings.PilotLegs_2.ToString("F0");
            textBox5.Text = _settings.Pilot_2.ToString("F0");
            textBox6.Text = _settings.Razgon1_2.ToString("F0");
            AcceleratingBox1.Text = _settings.Razgon1_4.ToString("F0");
            AcceleratingBox2.Text = _settings.Razgon2_4.ToString("F0");
            AcceleratingBox3.Text = _settings.Razgon3_4.ToString("F0");
            PilotLegs.Text = _settings.PilotLegs_4.ToString("F0");
            PilotBox.Text = _settings.Pilot_4.ToString("F0");
        }
    }
}
