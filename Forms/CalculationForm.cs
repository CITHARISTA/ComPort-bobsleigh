using ComPort.Models;
using ComPort.Repositories.Json.Interfaces;
using ComPort.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ComPort.Forms
{
    public partial class CalculationForm : Form
    {
        private readonly IIOBean _iOBean;
        private readonly IIOSettings _iOSettings;
        private readonly IIOSportsman _iOSportsman;
        private readonly IIOResult _iORes;
        private readonly LoadCalculateService _loadCalculate;
        private MainForm _mainForm;
        private List<Bean> Beans { get; set; }
        private Settings _settingsData; 
        private List<Sportsman> Sportsmen { get; set; }
        public CalculationForm(
            MainForm form,
            IIOBean iOBean,
            IIOSettings iOSettings,
            IIOResult iOResult,
            IIOSportsman iOSportsman)
        {
            InitializeComponent();
            _mainForm = form;
            _iOSettings = iOSettings;
            _iOBean = iOBean;
            _iOSportsman = iOSportsman;
            _iORes = iOResult;
            _loadCalculate = ContainerService.GetInject<LoadCalculateService>();
            Sportsmen = _iOSportsman.GetData();
            Beans = _iOBean.GetData();
            _settingsData = _iOSettings.GetData();
            InitHandlers();
        }

        private void InitHandlers()
        {
            var gruzControl = new List<Control> { RequiredLoad, front };
            gruzControl.ForEach(x => x.AddHandlers(Gruz));

            var clearControl = new List<Control> { Pilot, Razgon1, Razgon2, Razgon3, Bean, Gender };
            clearControl.ForEach(x => x.AddHandlers(ClearCalcResults));
        }

        private void Bean_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSportsmenInputs();
            EnabledRazgon(false);
            var bean = GetBeanFromInput();
            if (bean.Type == "4")
            {
                EnabledRazgon();
                foreach (var sportsman in Gender.Text == "Ж" 
                    ? Sportsmen.Where(x => x.Gender == "Ж") 
                    : Sportsmen.Where(x => x.Gender == "М"))
                {
                    Razgon2.Items.Add(sportsman.FullName);
                    Razgon3.Items.Add(sportsman.FullName);
                }
            }

            foreach (var sportsman in Gender.Text == "Ж"
                ? Sportsmen.Where(x => x.Gender == "Ж")
                : Sportsmen.Where(x => x.Gender == "М"))
            {
                Pilot.Items.Add(sportsman.FullName);
                Razgon1.Items.Add(sportsman.FullName);
            }
        }

        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bean.Items.Clear();
            Bean.Text = string.Empty;
            ClearSportsmenInputs();
            InitBeans();
        }

        private void EnabledRazgon(bool isEnabled = true)
        {
            Razgon2.Enabled = isEnabled;
            Razgon3.Enabled = isEnabled;
            Razgon2Text.Enabled = isEnabled;
            Razgon3Text.Enabled = isEnabled;
        }

        private Bean GetBeanFromInput()
        {
            if (Bean.SelectedIndex > -1)
            {
                return Gender.Text == "Ж"
                    ? Beans.Where(x => x.Type == "2").ToList()[Bean.SelectedIndex]
                    : Beans[Bean.SelectedIndex];
            }

            return null;
        }

        private void ClearSportsmenInputs()
        {
            Pilot.Items.Clear();
            Razgon1.Items.Clear();
            Razgon2.Items.Clear();
            Razgon3.Items.Clear();
            Pilot.Text = string.Empty;
            Razgon1.Text = string.Empty;
            Razgon2.Text = string.Empty;
            Razgon3.Text = string.Empty;
        }

        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {

                var bean = GetBeanFromInput();
                var frontRes = GetFront(bean);

                front.Text = frontRes.ToString("F2");
                double weight = 0;
                if (Razgon2.Enabled)
                {
                    weight = bean.Weight + Sportsmen[Pilot.SelectedIndex].Weight + Sportsmen[Razgon1.SelectedIndex].Weight +
                        Sportsmen[Razgon2.SelectedIndex].Weight + Sportsmen[Razgon3.SelectedIndex].Weight;
                }
                else
                {
                    weight = bean.Weight + Sportsmen[Pilot.SelectedIndex].Weight + Sportsmen[Razgon1.SelectedIndex].Weight;
                }
                var rearRes = weight - frontRes;
                Rear.Text = rearRes.ToString("F2");
                FPercent.Text = ((frontRes / weight) * 100).ToString("F0");
                RPercent.Text = ((rearRes / weight) * 100).ToString("F0");
                Gruz();
            }
        }

        private void InitBeans()
        {
            if (Gender.Text == "Ж")
            {
                foreach (var bean in Beans.Where(x => x.Type == "2"))
                {
                    Bean.Items.Add($"{bean.Name}\t ( {bean.Type} )");
                }
            }
            else if (Gender.Text == "М")
            {
                foreach (var bean in Beans)
                {
                    Bean.Items.Add($"{bean.Name}\t ( {bean.Type} )");
                }
            }
        }
        private void ClearCalcResults()
        {
            front.Text = string.Empty;
            Rear.Text = string.Empty;
            RPercent.Text = string.Empty;
            FPercent.Text = string.Empty;
            Position.Text = string.Empty;
            Weight.Text = string.Empty;
            NameBox.Text = string.Empty;
        }
        private bool ValidData()
        {
            if (IsEmptyData())
            {
                MessageBox.Show("Некоторые ячейки пусты", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (IsRepeatSportmen())
            {
                MessageBox.Show("Один и тот же спортсмен на нескольких местах", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool IsEmptyData() => string.IsNullOrEmpty(Gender.Text) 
            || string.IsNullOrEmpty(Bean.Text)
            || string.IsNullOrEmpty(Pilot.Text) 
            || string.IsNullOrEmpty(Razgon1.Text)
            || Razgon2.Enabled == true && (string.IsNullOrEmpty(Razgon2.Text) || string.IsNullOrEmpty(Razgon3.Text));

        private bool IsRepeatSportmen()
        {
            if (!Razgon2.Enabled)
            {
                return Pilot.Text == Razgon1.Text ? true : false;
            }
            else
            {
                return Pilot.Text == Razgon1.Text || Pilot.Text == Razgon2.Text 
                    || Pilot.Text == Razgon3.Text || Razgon1.Text == Razgon2.Text 
                    || Razgon1.Text == Razgon3.Text|| Razgon2.Text == Razgon3.Text 
                    ? true: false;
            }
        }

        private double GetFront(Bean bean)
        {
            var fl = bean.FrontLeft;
            var fr = bean.FrontRight;

            var m = new List<double>()
            {
                Sportsmen[Pilot.SelectedIndex].WeightOnLeg,
                Sportsmen[Pilot.SelectedIndex].WeightOnBody + Sportsmen[Razgon1.SelectedIndex].WeightOnLeg,
                Sportsmen[Razgon1.SelectedIndex].WeightOnBody
            };
            var L = new List<double>();

            if (bean.Type == "4")
            {
                m[2] += Sportsmen[Razgon2.SelectedIndex].WeightOnLeg;
                m.Add(Sportsmen[Razgon2.SelectedIndex].WeightOnBody + Sportsmen[Razgon3.SelectedIndex].WeightOnLeg);
                m.Add(Sportsmen[Razgon3.SelectedIndex].WeightOnBody);

                L.Add(_settingsData.PilotLegs_4);
                L.Add(_settingsData.Pilot_4);
                L.Add(_settingsData.Razgon1_4);
                L.Add(_settingsData.Razgon2_4);
                L.Add(_settingsData.Razgon3_4);
            }
            else
            {
                L.Add(_settingsData.PilotLegs_2);
                L.Add(_settingsData.Pilot_2);
                L.Add(_settingsData.Razgon1_2);
            }


            double result = 0;
            for (int i = 0; i < m.Count(); i++)
            {
                result += (m[i] * L[i]) / (bean.DistanceExis);
            }

            return result + fl + fr;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            Close();
        }

        private Result GetResultFromInputs()
        {
            var result = new Result
            {
                Name = NameBox.Text,
                Pilot = Pilot.Text + " " + Sportsmen[Pilot.SelectedIndex].DateTime,
                Razgon1 = Razgon1.Text + " " + Sportsmen[Razgon1.SelectedIndex].DateTime,
                DateTime = dateTime.Value,
                RequiredLoad = double.Parse(RequiredLoad.Text),
                FP = double.Parse(FPercent.Text),
                RP = double.Parse(RPercent.Text),
                PosLoad = double.Parse(Position.Text),
                WeightLoad = double.Parse(Weight.Text),
                Weight = double.Parse(front.Text) + double.Parse(Rear.Text) + double.Parse(Weight.Text)
            };
            var bean = GetBeanFromInput();
            if (bean.Type == "4")
            {
                result.Razgon2 = !string.IsNullOrEmpty(Razgon2.Text)
                    ? Razgon2.Text + " " + Sportsmen[Razgon2.SelectedIndex].DateTime
                    : string.Empty;
                result.Razgon3 = !string.IsNullOrEmpty(Razgon3.Text)
                    ? Razgon3.Text + " " + Sportsmen[Razgon3.SelectedIndex].DateTime
                    : string.Empty;
            }

            return result;
        }

        private void Gruz()
        {
            try
            {
                var data = new DataForLoadCalc
                {
                    RequiredLoad = RequiredLoad,
                    Gender = Gender,
                    Type = new TextBox { Text = Razgon2.Enabled ? "4" : "2" },
                    DistanceExis = new TextBox { Text = GetBeanFromInput().DistanceExis.ToString() },
                    BackWeight = Rear,
                    FrontWeight = front,
                    LoadPosition = Position,
                    LoadWeight = Weight
                };

                _loadCalculate.LoadCalculate(data);
            }
            catch { }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(front.Text))
            {
                MessageBox.Show($"Нагрузка не рассчитана", "Информация,", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(NameBox.Text))
            {
                MessageBox.Show($"Заполните поле с названием расчета", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var listOfResults = _iORes.GetData();
                try
                {
                    var newRes = GetResultFromInputs();
                    listOfResults.Add(newRes);
                    _iORes.SaveData(listOfResults);
                    ClearAll();
                    MessageBox.Show($"Расчет {newRes.Name} успешно сохранен!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show($"Некорректные данные!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void ClearAll()
        {
            ClearCalcResults();
            ClearSportsmenInputs();
            Bean.Items.Clear();
            Bean.Text = string.Empty;
            InitBeans();
        }

        private void ButClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
