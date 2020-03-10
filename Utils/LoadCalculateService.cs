using ComPort.Models;
using ComPort.Repositories.Json.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPort.Utils
{
    public class LoadCalculateService
    {
        private Settings _settings;
        private readonly IIOSettings _iOSettings;
        public LoadCalculateService(IIOSettings iOSettings)
        {
            _iOSettings = iOSettings;
            _settings = _iOSettings.GetData();
        }
        public void LoadCalculate(DataForLoadCalc data)
        {
            var required = Convert.ToDouble(data.RequiredLoad.Text);
            var weightReq = (required / 100) * (data.Type.Text == "4" ? _settings.WeightM_4 : data.Gender.Text == "М" ? _settings.WeightM_2 : _settings.WeightW_2);
            var weightFront = double.Parse(data.FrontWeight.Text);
            var R = weightReq - weightFront;
            var m = (data.Type.Text == "4" ? _settings.WeightM_4 : data.Gender.Text == "М" ? _settings.WeightM_2 : _settings.WeightW_2) - double.Parse(data.FrontWeight.Text) - double.Parse(data.BackWeight.Text);

            data.LoadWeight.Text = Convert.ToInt32(m).ToString();
            data.LoadPosition.Text = ((R * double.Parse(data.DistanceExis.Text) / m) + 600).ToString("F2");
        }
    }
}
