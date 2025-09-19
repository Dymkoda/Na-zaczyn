using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataBase
{
    internal class Weather
    {
        public int Id { get; set; }
        public string MeasyredBy { get; set; } = string.Empty;
        public DateTime MeasyrementDate { get; set; }
    }
}
