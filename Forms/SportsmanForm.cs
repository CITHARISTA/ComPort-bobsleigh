using ComPort.Models;
using ComPort.Repositories.Json.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPort.Forms
{
    public partial class SportsmanForm : Form
    {
        private readonly IIOSportsman _iOData;
        private List<Sportsman> Sportsmen { get; set; }
        private List<TextBox> TextBoxes { get; set; }
        private MainForm _mainForm;
        public SportsmanForm(MainForm mainForm, IIOSportsman iOSportsman)
        {
            InitializeComponent();
            TextBoxes = InitTextBoxes();
            _mainForm = mainForm;
            _iOData = iOSportsman;
            var WeightBoxes = new List<TextBox> { WeightOnLeg, WeightOnBody };
            WeightBoxes.ForEach(x => x.AddHandlers(CalcWight));
            InitSprotsmenList();
            CreateListSportmen();
        }

        private void CalcWight()
        {
            try
            {
                Weight.Text = (Convert.ToDouble(WeightOnLeg.Text) + Convert.ToDouble(WeightOnBody.Text)).ToString("F2");
            }
            catch { };

        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (ActionInput.Text == "Добавить")
            {
                try
                {
                    if (!ValidatorInput() && !string.IsNullOrEmpty(Gender.Text))
                    {
                        var sportsman = GetDataFromInputs();
                        listBox.Items.Add($"{sportsman.FullName} ({sportsman.Team})\t{sportsman.DateTime}");
                        Sportsmen.Add(sportsman);
                        _iOData.SaveData(Sportsmen);
                        MessageBox.Show($"Спортсмен: \"{sportsman.FullName}\"\n успешно сохранен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputs();
                    }
                    else throw new Exception("Некорректные данные");
                }
                catch
                {
                    MessageBox.Show($"Некорректные данные!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(ActionInput.Text == "Удалить")
            {
                int index = listBox.SelectedIndex;
                MessageBox.Show($"Спортсмен {Sportsmen[index].FullName} успешно удален!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox.Items.RemoveAt(index);
                Sportsmen.RemoveAt(index);
                _iOData.SaveData(Sportsmen);
                ClearInputs();
            }
            else if(ActionInput.Text == "Редактировать")
            {
                if (listBox.SelectedIndex > -1)
                {
                    try
                    {
                        if (!ValidatorInput() && !string.IsNullOrEmpty(Gender.Text))
                        {
                            var sportsman = GetDataFromInputs();
                            Sportsmen[listBox.SelectedIndex] = sportsman;
                            listBox.Items[listBox.SelectedIndex] = $"{sportsman.FullName} ({sportsman.Team})\t{sportsman.DateTime}";
                            MessageBox.Show($"Данные спортсмена: \"{sportsman.FullName}\"\n успешно изменены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _iOData.SaveData(Sportsmen);
                        }
                        else throw new Exception("Некорректные данные");
                    }
                    catch
                    {
                        MessageBox.Show($"Некорректные данные!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void CreateListSportmen()
        {
            listBox.Items.Clear();
            foreach (var sportsman in Sportsmen)
            {
                listBox.Items.Add($"{sportsman.FullName} ({sportsman.Team})\t{sportsman.DateTime}");
            }
        }

        private void InitSprotsmenList() => Sportsmen = _iOData.GetData();
        private Sportsman GetDataFromInputs() =>
            new Sportsman()
            {
                FullName = FullName.Text,
                Gender = Gender.Text,
                Team = Team.Text,
                DateTime = dateTime.Value,
                WeightOnLeg = Convert.ToDouble(WeightOnLeg.Text),
                WeightOnBody = Convert.ToDouble(WeightOnBody.Text),
                Weight = Convert.ToDouble(Weight.Text),
                Height = Convert.ToInt32(Height.Text)
            };
        private void ClearInputs()
        {
            foreach (var input in TextBoxes)
            {
                input.Text = string.Empty;
            }
            Gender.Text = string.Empty;
            dateTime.Text = string.Empty;
        }
        private bool ValidatorInput() => TextBoxes.Any(x => string.IsNullOrEmpty(x.Text));

        private void ActionInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSave.Text = "Сохранить";
            EnabledInputs(false);
            if (ActionInput.Text == "Добавить")
            {
                EnabledInputs();
                ClearInputs();
                listBox.Enabled = false;
            }
            else if (ActionInput.Text == "Удалить")
            {
                buttonSave.Text = "Удалить";
                listBox.Enabled = true;
            }
            else if (ActionInput.Text == "Редактировать")
            {
                listBox.Enabled = true;
                if (listBox.SelectedIndex > -1)
                {
                    EnabledInputs();
                }
            }

        }
        private void EnabledInputs(bool isEnabled = true)
        {
            foreach (var input in TextBoxes)
            {
                input.Enabled = isEnabled;
            }
            dateTime.Enabled = isEnabled;
            Gender.Enabled = isEnabled;
            Weight.Enabled = false;
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ActionInput.Text == "Удалить" || ActionInput.Text == "Редактировать")
            {
                if (listBox.SelectedIndex > -1)
                {
                    if (ActionInput.Text == "Редактировать")
                    {
                        EnabledInputs();
                    }

                    var sportman = Sportsmen[listBox.SelectedIndex];
                    FullName.Text = sportman.FullName;
                    Gender.Text = sportman.Gender;
                    Team.Text = sportman.Team;
                    dateTime.Text = sportman.DateTime.ToString();
                    WeightOnLeg.Text = sportman.WeightOnLeg.ToString();
                    WeightOnBody.Text = sportman.WeightOnBody.ToString();
                    Weight.Text = sportman.Weight.ToString();
                    Height.Text = sportman.Height.ToString();
                }
                else
                {
                    EnabledInputs(false);
                }
            }
        }

        private void GenderSort_CheckedChanged(object sender, EventArgs e)
        {
            Sort();
            ClearInputs();
        }

        private void TeamSort_CheckedChanged(object sender, EventArgs e)
        {
            Sort();
            ClearInputs();
        }

        private void Sort()
        {
            Sportsmen = Sportsmen.OrderBy(x => x.FullName).ToList();

            Sportsmen = GenderSort.Checked == true && TeamSort.Checked == true
                ? Sportsmen.OrderBy(x => x.Gender).ThenBy(x => x.Team).ToList()
                : TeamSort.Checked == true
                ? Sportsmen.OrderBy(x => x.Team).ToList()
                : GenderSort.Checked == true
                ? Sportsmen.OrderBy(x => x.Gender).ToList()
                : Sportsmen;

            CreateListSportmen();
        }

        private List<TextBox> InitTextBoxes() => new List<TextBox>
        {
            WeightOnLeg,
            WeightOnBody,
            Height,
            Weight,
            Team,
            FullName
        };
    }
}
