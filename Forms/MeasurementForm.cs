using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Globalization;
using ComPort.Models;
using ComPort.Forms;
using ComPort.Utils;
using ComPort.Repositories.Json.Interfaces;

namespace ComPort
{
    public partial class MeasurementForm : Form
    {
        private readonly IIOBean _iOData;
        private MainForm _mainForm;
        private List<Bean> Beans { get; set; }

        public MeasurementForm(MainForm mainForm, IIOBean iOBean)
        {
            InitializeComponent();
            InitAddHandlers();
            _iOData = iOBean;
            Beans = _iOData.GetData();
            _mainForm = mainForm;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }

        private void InitAddHandlers()
        {
            var textBoxes = new List<Control> { textBoxFL, textBoxFR, textBoxBL, textBoxBR };
            textBoxes.ForEach(x => x.AddHandlers(Calc));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            ComPortComboBox.Items.AddRange(ports);
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                var textBoxes = new List<TextBox> { textBoxFL, textBoxFR, textBoxBL, textBoxBR };
                var portConnect = new PortConnectionService(textBoxes);

                portConnect.Connect(ConnectButton, ComPortComboBox);
            }
            catch { }
        }

        private void Calc()
        {
            try
            {
                var f = double.Parse(textBoxFL.Text) + double.Parse(textBoxFR.Text);
                textBoxF.Text = f.ToString("F2");
                textBoxF_percent.Text = (100 * f / GetSum()).ToString("F2");

                var b = double.Parse(textBoxBL.Text) + double.Parse(textBoxBR.Text);
                textBoxB.Text = b.ToString("F2");
                textBoxB_percent.Text = (100 * b / GetSum()).ToString("F2");

                textBoxSum.Text = GetSum().ToString("F2");
            }
            catch { }
        }

        private double GetSum() =>
            double.Parse(textBoxFL.Text) + double.Parse(textBoxFR.Text) + double.Parse(textBoxBL.Text) + double.Parse(textBoxBR.Text);


        private bool InputsIsNotEmpty() => string.IsNullOrEmpty(NameBean.Text) ? false :
                string.IsNullOrEmpty(TypeBox.Text) ? false :
                string.IsNullOrEmpty(TeamBox.Text) ? false :
                string.IsNullOrEmpty(dateTime.Text) ? false :
                string.IsNullOrEmpty(textBoxFR.Text) ? false :
                string.IsNullOrEmpty(textBoxBR.Text) ? false :
                string.IsNullOrEmpty(textBoxFL.Text) ? false :
                string.IsNullOrEmpty(textBoxBL.Text) ? false :
                string.IsNullOrEmpty(textBoxSum.Text) ? false :
                string.IsNullOrEmpty(textBoxF.Text) ? false :
                string.IsNullOrEmpty(textBoxB.Text) ? false :
                string.IsNullOrEmpty(textBoxF_percent.Text) ? false :
                string.IsNullOrEmpty(textBoxB_percent.Text) ? false :
                string.IsNullOrEmpty(DistanceExis.Text) ? false : true ;

        private void ClearInputs()
        {
            NameBean.Text = string.Empty;
            TypeBox.Text = string.Empty;
            TeamBox.Text = string.Empty;
            DistanceExis.Text = string.Empty;
        }

        private Bean CreatNewBean() =>
            new Bean
            {
                Name = NameBean.Text,
                Type = TypeBox.Text,
                Team = TeamBox.Text,
                DateTime = dateTime.Value,
                Weight = Convert.ToDouble(textBoxSum.Text),
                FrontRight = Convert.ToDouble(textBoxFR.Text),
                FrontLeft = Convert.ToDouble(textBoxFL.Text),
                RearLeft = Convert.ToDouble(textBoxBL.Text),
                RearRight = Convert.ToDouble(textBoxBR.Text),
                FrontLoad = Convert.ToDouble(textBoxF.Text),
                RearLoad = Convert.ToDouble(textBoxB.Text),
                FrontLoadPercent = Convert.ToDouble(textBoxF_percent.Text),
                DistanceExis = Convert.ToDouble(DistanceExis.Text),
                RearLoadPercent = Convert.ToDouble(textBoxB_percent.Text)
            };

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (InputsIsNotEmpty())
            {
                try
                {
                    var bean = CreatNewBean();
                    Beans.Add(bean);
                    _iOData.SaveData(Beans);
                    ClearInputs();
                    MessageBox.Show($"Боб \"{bean.Name}\" успешно сохранен!", "Сообщение", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Некорректные данные!", "Сообщение", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Некоторые обязательные поля пустые!", "Сообщение", MessageBoxButtons.OK);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            Close();
        }

    }
}
