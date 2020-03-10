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
    public partial class BeanForm : Form
    {
        private readonly IIOBean _iOData;
        private List<Bean> Beans { get; set; }
        private List<TextBox> TextBoxes { get; set; }
        private MainForm _mainForm;
        public BeanForm(MainForm mainForm, IIOBean iOBean)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _iOData = iOBean;
            InitAddHandlers();
            TextBoxes = InitTextBoxes();
            Beans = _iOData.GetData();
            CreateListBeans();
        }

        private void InitAddHandlers()
        {
            var calcControl = new List<TextBox> { textBoxFL, textBoxFR, textBoxBL, textBoxBR };
            calcControl.ForEach(x => x.AddHandlers(Calc));
        }
        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearInputs();
            if (listBox.SelectedIndex > -1)
            {
                var bean = Beans[listBox.SelectedIndex];
                NameBean.Text = bean.Name;
                TypeBox.Text = bean.Type;
                TeamBox.Text = bean.Team;
                dateTime.Text = bean.DateTime.ToString();
                textBoxFR.Text = bean.FrontRight.ToString();
                textBoxBR.Text = bean.RearRight.ToString();
                textBoxBL.Text = bean.RearLeft.ToString();
                textBoxFL.Text = bean.FrontLeft.ToString();
                textBoxSum.Text = bean.Weight.ToString();
                textBoxB.Text = bean.RearLoad.ToString();
                textBoxF.Text = bean.FrontLoad.ToString();
                textBoxF_percent.Text = bean.FrontLoadPercent.ToString();
                textBoxB_percent.Text = bean.RearLoadPercent.ToString();
                DistanceExis.Text = bean.DistanceExis.ToString();
            }
        }
        private void CreateListBeans()
        {
            listBox.Items.Clear();
            foreach (var bean in Beans)
            {
                listBox.Items.Add($"{string.Format("{0}{4}{1}\t{2}\t{3}", bean.Name, bean.Team, bean.Type, bean.DateTime, bean.Name.Length < 8 ? "\t\t" :"\t" )}");
            }
        }

        private void TypeSort_CheckedChanged(object sender, EventArgs e)
        {
            SortListBox();
        }

        private void TeamSort_CheckedChanged(object sender, EventArgs e)
        {
            SortListBox();
        }

        private void SortListBox()
        {
            ClearInputs();
            Beans = Beans.OrderBy(x => x.Name).ToList();
            Beans = TypeSort.Checked == true && TeamSort.Checked == true
                ? Beans.OrderBy(x => x.Type).ThenBy(x => x.Team).ToList()
                : TeamSort.Checked == true
                ? Beans.OrderBy(x => x.Team).ToList()
                : TypeSort.Checked == true
                ? Beans.OrderBy(x => int.Parse(x.Type)).ToList()
                : Beans;

            CreateListBeans();
        }

        private void ActionInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabledInputs(false);
            buttonSave.Text = ActionInput.Text == "Удалить" ? "Удалить" : "Сохранить";
            if (ActionInput.Text == "Редактировать")
            {
                EnabledInputs();
            }

        }
        private List<TextBox> InitTextBoxes() => new List<TextBox>
            {
                NameBean,
                TeamBox,
                textBoxFR,
                textBoxBR,
                textBoxBL,
                textBoxFL,
                textBoxSum,
                textBoxB,
                textBoxF,
                textBoxF_percent,
                textBoxB_percent,
                DistanceExis,
            };

        private void ClearInputs()
        {
            foreach (var segment in TextBoxes)
            {
                segment.Text = string.Empty;
            }
            dateTime.Text = string.Empty;
        }
        private void EnabledInputs(bool isEnabled = true)
        {
            foreach( var segment in TextBoxes)
            {
                segment.Enabled = isEnabled;
            }
            dateTime.Enabled = isEnabled;
        }

        private bool ValidInputs() =>
            TextBoxes.Any(x => string.IsNullOrEmpty(x.Text)) || string.IsNullOrEmpty(dateTime.Text);

        private Bean GetDataFromInputs() =>
            new Bean
            {
                Name = NameBean.Text,
                Type = TypeBox.Text,
                Team = TeamBox.Text,
                DateTime = dateTime.Value,
                FrontRight = double.Parse(textBoxFR.Text),
                RearRight = double.Parse(textBoxBR.Text),
                RearLeft = double.Parse(textBoxBL.Text),
                FrontLeft = double.Parse(textBoxFL.Text),
                Weight = double.Parse(textBoxSum.Text),
                RearLoad = double.Parse(textBoxB.Text),
                FrontLoad = double.Parse(textBoxF.Text),
                FrontLoadPercent = double.Parse(textBoxF_percent.Text),
                RearLoadPercent = double.Parse(textBoxB_percent.Text),
                DistanceExis = double.Parse(DistanceExis.Text)
            };
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (ActionInput.Text != "Удалить" && ActionInput.Text != "Редактировать")
            {
                MessageBox.Show("Выберете действие Редактировать или Удалить", "Неизвестное действие!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (listBox.SelectedIndex > -1)
            {
                if (ActionInput.Text == "Удалить")
                {
                    int index = listBox.SelectedIndex;
                    MessageBox.Show($"Боб под с названием {Beans[index].Name} успешно удален!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listBox.Items.RemoveAt(index);
                    Beans.RemoveAt(index);
                    _iOData.SaveData(Beans);
                    ClearInputs();
                }
                else
                {
                    try
                    {
                        if (!ValidInputs())
                        {
                            var bean = GetDataFromInputs();
                            Beans[listBox.SelectedIndex] = bean;
                            listBox.Items[listBox.SelectedIndex] = $"{string.Format("{0}{4}{1}\t{2}\t{3}", bean.Name, bean.Team, bean.Type, bean.DateTime, bean.Name.Length < 8 ? "\t\t" : "\t")}";
                            MessageBox.Show($"Данные боба: \"{bean.Name}\"\n успешно изменены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _iOData.SaveData(Beans);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    catch
                    {
                        MessageBox.Show($"Некорректные данные!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show($"Выберете боб который хотите {ActionInput.Text}", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            Close();
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

    }
}
