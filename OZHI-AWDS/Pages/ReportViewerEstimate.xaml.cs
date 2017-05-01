using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OZHI_AWDS.Pages
{
    /// <summary>
    /// Interaction logic for ReportViewerEstimate.xaml
    /// </summary>
    public partial class ReportViewerEstimate : Page
    {
        DataTable dt;

        public ReportViewerEstimate()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Service", typeof(string)));
            dt.Columns.Add(new DataColumn("ClientID", typeof(string)));
            dt.Columns.Add(new DataColumn("Project", typeof(string)));
            dt.Columns.Add(new DataColumn("Address", typeof(string)));
            dt.Columns.Add(new DataColumn("LegalDescription", typeof(string)));
            dt.Columns.Add(new DataColumn("City", typeof(string)));
            dt.Columns.Add(new DataColumn("Province", typeof(string)));
            dt.Columns.Add(new DataColumn("PostalCode", typeof(string)));
            dt.Columns.Add(new DataColumn("LoanType", typeof(string)));
            dt.Columns.Add(new DataColumn("LoanTypeF", typeof(string)));
            dt.Columns.Add(new DataColumn("Telephone", typeof(string)));
            dt.Columns.Add(new DataColumn("CMHCAccountNumber", typeof(string)));
            dt.Columns.Add(new DataColumn("AgentInspectionNumber", typeof(string)));
            dt.Columns.Add(new DataColumn("InspectionDate", typeof(string)));
            dt.Columns.Add(new DataColumn("Inspector1", typeof(string)));
            dt.Columns.Add(new DataColumn("Inspector2", typeof(string)));
            dt.Columns.Add(new DataColumn("WorkSpecification", typeof(string)));
            dt.Columns.Add(new DataColumn("Priority", typeof(string)));
            dt.Columns.Add(new DataColumn("ImperialDescription", typeof(string)));
            dt.Columns.Add(new DataColumn("MetricDescription", typeof(string)));
            dt.Columns.Add(new DataColumn("ImperialQuanity", typeof(string)));
            dt.Columns.Add(new DataColumn("MetricQuanity", typeof(string)));
            dt.Columns.Add(new DataColumn("MaterialEstimate", typeof(string)));
            dt.Columns.Add(new DataColumn("LabourEstimate", typeof(string)));
            dt.Columns.Add(new DataColumn("WorkSpecificationDescription", typeof(string)));
        }
    }
}
