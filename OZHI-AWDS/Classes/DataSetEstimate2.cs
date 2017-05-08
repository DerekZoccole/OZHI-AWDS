using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZHI_AWDS.Classes
{
    public class DataSetEstimate2
    {
        public string WorkNumber { get; set; }
        public string Priority { get; set; }
        public string Section { get; set; }
        public string Urgency { get; set; }
        public string WorkSpecificationDescription { get; set; }
        public string ImperialUnits { get; set; }
        public string MetricUnits { get; set; }
        public string MetricDescription { get; set; }
        public string ImperialDescription { get; set; }
        public string ImperialQuanity { get; set; }
        public string MetricQuanity { get; set; }
        public string MaterialEstimate { get; set; }
        public string LabourEstimate { get; set; }
        public string GST { get; set; }
        public string PST { get; set; }
        public string Total { get; set; }
    }
}
