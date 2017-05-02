using Microsoft.Reporting.WinForms;
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
            dt.Columns.Add(new DataColumn("ServiceDescription", typeof(string)));
            dt.Columns.Add(new DataColumn("Project", typeof(string)));
            dt.Columns.Add(new DataColumn("ClientID", typeof(string)));
            dt.Columns.Add(new DataColumn("AlternateName", typeof(string)));
            dt.Columns.Add(new DataColumn("LoanType", typeof(string)));
            dt.Columns.Add(new DataColumn("LoanTypeF", typeof(string)));
            dt.Columns.Add(new DataColumn("Contact", typeof(string)));
            dt.Columns.Add(new DataColumn("Telephone", typeof(string)));
            dt.Columns.Add(new DataColumn("Address", typeof(string)));
            dt.Columns.Add(new DataColumn("CMHCAccountNumber", typeof(string)));
            dt.Columns.Add(new DataColumn("LegalDescription", typeof(string)));
            dt.Columns.Add(new DataColumn("AgentInspectionNumber", typeof(string)));
            dt.Columns.Add(new DataColumn("City", typeof(string)));
            dt.Columns.Add(new DataColumn("Province", typeof(string)));
            dt.Columns.Add(new DataColumn("InspectionDate", typeof(string)));
            dt.Columns.Add(new DataColumn("PostalCode", typeof(string)));
            dt.Columns.Add(new DataColumn("Inspector1", typeof(string)));
            dt.Columns.Add(new DataColumn("Inspector2", typeof(string)));
            dt.Columns.Add(new DataColumn("ItemCode", typeof(string)));
            dt.Columns.Add(new DataColumn("WorkSpecification", typeof(string)));
            dt.Columns.Add(new DataColumn("Estimate", typeof(string)));
            dt.Columns.Add(new DataColumn("WorkNumber", typeof(string)));
            dt.Columns.Add(new DataColumn("Priority", typeof(string)));
            dt.Columns.Add(new DataColumn("Section", typeof(string)));
            dt.Columns.Add(new DataColumn("Urgency", typeof(string)));
            dt.Columns.Add(new DataColumn("WorkSpecificationDescription", typeof(string)));
            dt.Columns.Add(new DataColumn("ImperialUnits", typeof(string)));
            dt.Columns.Add(new DataColumn("MetricUnits", typeof(string)));
            dt.Columns.Add(new DataColumn("ImperialDescription", typeof(string)));
            dt.Columns.Add(new DataColumn("MetricDescription", typeof(string)));
            dt.Columns.Add(new DataColumn("ImperialQuanity", typeof(string)));
            dt.Columns.Add(new DataColumn("MetricQuanity", typeof(string)));
            dt.Columns.Add(new DataColumn("MaterialEstimate", typeof(string)));
            dt.Columns.Add(new DataColumn("LabourEstimate", typeof(string)));

            DataRow dr1 = dt.NewRow();
            dr1["Service"] = "RRAP";
            dr1["ServiceDescription"] = "Residential Rehabilitation Assistance Program";
            dr1["Project"] = "Address";
            dr1["ClientID"] = 1;
            dr1["AlternateName"] = "Alternate Name";
            dr1["LoanType"] = "Homeowner";
            dr1["LoanTypeF"] = "";
            dr1["Contact"] = "Contact Name";
            dr1["Telephone"] = "411";
            dr1["Address"] = "123 Fake Street";
            dr1["CMHCAccountNumber"] = "111-111-111";
            dr1["LegalDescription"] = "";
            dr1["AgentInspectionNumber"] = "";
            dr1["City"] = "Thunder Bay";
            dr1["Province"] = "ON";
            dr1["InspectionDate"] = "01/01/1900";
            dr1["PostalCode"] = "A1A1A1";
            dr1["Inspector1"] = "Derek Zoccole";
            dr1["Inspector2"] = "";
            dr1["ItemCode"] = "Item Code";
            dr1["WorkSpecification"] = "Work Item";
            dr1["Estimate"] = "Estimate";
            dr1["WorkNumber"] = "0 09260B";
            dr1["Priority"] = "Eligible";
            dr1["Section"] = "Section (7.2)";
            dr1["Urgency"] = "MEDIUM";
            dr1["WorkSpecificationDescription"] = "Supply labour and materials to install 12mm (1/2 inch) gypsum board to finish interior walls.  Joint fill tape and sand ready for painting.  Paint all wals and ceiling with primer sealer and 2 finish coats.  LOCATION: all rooms";
            dr1["ImperialUnits"] = "";
            dr1["MetricUnits"] = "";
            dr1["ImperialDescription"] = "";
            dr1["MetricDescription"] = "";
            dr1["ImperialQuanity"] = "";
            dr1["MetricQuanity"] = "";
            dr1["MaterialEstimate"] = 1200;
            dr1["LabourEstimate"] = 2750;
            dt.Rows.Add(dr1);

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet2";
            reportDataSource.Value = dt;
            reportViewerEstimate.LocalReport.ReportPath = "C:\\Users\\Derek Z\\documents\\visual studio 2015\\Projects\\OZHI-AWDS\\OZHI-AWDS\\Reports\\EstimateEng.rdlc";

            reportViewerEstimate.LocalReport.DataSources.Add(reportDataSource);
            reportViewerEstimate.RefreshReport();
        }
    }
}
