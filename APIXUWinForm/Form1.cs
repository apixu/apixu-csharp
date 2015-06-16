using APIXULib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIXU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string key = "YOUR_API_KEY";
            IRepository repo = new Repository();
            var GetCityForecastWeatherResult = repo.GetWeatherData(key, GetBy.CityName, "paris", Days.Three);
            var GetByLatLongForecastWeatherResult = repo.GetWeatherDataByLatLong(key, "30.2669444", "-97.7427778", Days.Three);
            var GetByIPForecastWeatherResult = repo.GetWeatherDataByAutoIP(key, Days.Three);


            var GetCityCurrentWeatherResult = repo.GetWeatherData( key, GetBy.CityName, "paris");
            var GetByLatLongCurrentWeatherResult = repo.GetWeatherDataByLatLong( key, "30.2669444", "-97.7427778");
            var GetByIPCurrentWeatherResult = repo.GetWeatherDataByAutoIP( key);

        }
    }
}
