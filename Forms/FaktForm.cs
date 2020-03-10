using ComPort.Models;
using ComPort.Repositories.Json.Interfaces;
using ComPort.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace ComPort.Forms
{
    public partial class FaktForm : Form
    {
        private readonly IIOFaktResult _iOData;
        private readonly LoadCalculateService _loadCalculate;
        private List<FaktResult> FaktResults { get; set; }
        private MainForm _mainForm;

        public FaktForm(MainForm mainForm, IIOFaktResult iOFaktResult)
        {
            InitializeComponent();
            Gender.Text = "М";
            InitAddHandlersTB();
            _iOData = iOFaktResult;
            _loadCalculate = ContainerService.GetInject<LoadCalculateService>();
            FaktResults = _iOData.GetData();
            _mainForm = mainForm;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }

        private void InitAddHandlersTB()
        {
            var calcControl = new List<Control> { textBoxFL, textBoxFR, textBoxBL, textBoxBR };
            calcControl.ForEach(x => x.AddHandlers(Calc));

            var gruzControl = new List<Control> { DistanceExis, textBoxF, textBoxB, RequiredLoad, TypeBox, Gender};
            gruzControl.ForEach(x => x.AddHandlers(Gruz));

            DistanceExis.AddHandlers(DistanceExisHandler);
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


        private bool InputsIsNotEmpty() => string.IsNullOrEmpty(NameMeas.Text) ? false : string.IsNullOrEmpty(TypeBox.Text)
            ? false : string.IsNullOrEmpty(TeamBox.Text) ? false : string.IsNullOrEmpty(dateTime.Text)
            ? false : string.IsNullOrEmpty(textBoxFR.Text) ? false : string.IsNullOrEmpty(textBoxBR.Text)
            ? false : string.IsNullOrEmpty(textBoxFL.Text) ? false : string.IsNullOrEmpty(textBoxBL.Text)
            ? false : string.IsNullOrEmpty(textBoxSum.Text) ? false : string.IsNullOrEmpty(textBoxF.Text)
            ? false : string.IsNullOrEmpty(textBoxB.Text) ? false : string.IsNullOrEmpty(textBoxF_percent.Text)
            ? false : string.IsNullOrEmpty(textBoxB_percent.Text) ? false : string.IsNullOrEmpty(DistanceExis.Text) 
            ? false : true;

        private void ClearInputs()
        {
            NameMeas.Text = string.Empty;
            TeamBox.Text = string.Empty;
        }

        private FaktResult CreatNewResult() =>
            new FaktResult
            {
                Name = NameMeas.Text,
                Type = TypeBox.Text,
                Team = TeamBox.Text,
                Date = dateTime.Value,
                Gender = Gender.Text,
                Weight = Convert.ToDouble(textBoxSum.Text),
                WeightF = Convert.ToDouble(textBoxF.Text),
                WeightB = Convert.ToDouble(textBoxB.Text),
                WeightF_P = Convert.ToDouble(textBoxF_percent.Text),
                WeightB_P = Convert.ToDouble(textBoxB_percent.Text),
                DistanceExis = Convert.ToDouble(DistanceExis.Text),
                Required = Convert.ToDouble(RequiredLoad.Text),
                WeightGruz = Convert.ToDouble(Weight.Text),
                DistanceGruz = Convert.ToDouble(Position.Text)
            };

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            _mainForm.Show();
            Close();
        }

        private void FaktForm_Load(object sender, EventArgs e)
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

        private void DistanceExisHandler()
        {
            try
            {
                if (string.IsNullOrEmpty(DistanceExis.Text))
                {
                    throw new Exception();
                }
                var t = double.Parse(DistanceExis.Text);
                label10.Visible = false;
            }
            catch
            {
                label10.Visible = true;
                label10.Text = "Для расчета положения груза введите расстояние между осями!";
                label10.ForeColor = Color.Red;
            }
        }

        private void Gruz()
        {
            try
            {
                var data = new DataForLoadCalc
                {
                    Type = TypeBox,
                    Gender = Gender,
                    LoadPosition = Position,
                    DistanceExis = DistanceExis,
                    RequiredLoad = RequiredLoad,
                    LoadWeight = Weight,
                    FrontWeight = textBoxF,
                    BackWeight = textBoxB
                };

                _loadCalculate.LoadCalculate(data);
            }
            catch { }
        }

        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeBox.Enabled = true;
            if (Gender.Text == "Ж" )
            {
                TypeBox.Enabled = false;
                TypeBox.Text = "2";
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (InputsIsNotEmpty())
            {
                try
                {
                    var result = CreatNewResult();
                    FaktResults.Add(result);
                    _iOData.SaveData(FaktResults);
                    ClearInputs();
                    MessageBox.Show($"Измерение \"{result.Name}\" успешно сохранено!", "Сообщение", MessageBoxButtons.OK);
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
    }
}

