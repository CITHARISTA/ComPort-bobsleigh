using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPort.Utils
{
    public class PortConnectionService
    {
        private SerialPort port;
        private List<TextBox> _textBoxes;

        private int currentTextBoxIndex = -1;

        public PortConnectionService(List<TextBox> textBoxes)
        {
            _textBoxes = textBoxes;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }


        private void Listen()
        {
            while (true)
            {
                var text = port.ReadLine();
                if (text.Contains("Reading"))
                {
                    currentTextBoxIndex = 0;
                }
                else if (currentTextBoxIndex >= 0 && currentTextBoxIndex < 4)
                {
                    var textBox = _textBoxes[currentTextBoxIndex];
                    textBox.Invoke((MethodInvoker)delegate { textBox.Text = text; });
                    currentTextBoxIndex++;
                }
            }
        }

        public void Connect(Button connectButton, ComboBox comPortComboBox)
        {
            port = new SerialPort(comPortComboBox.SelectedItem.ToString(), 57600);
            port.Open();
            var thread = new Thread(Listen);
            thread.Start();
            connectButton.Enabled = false;
            comPortComboBox.Enabled = false;
        }
    }
}
