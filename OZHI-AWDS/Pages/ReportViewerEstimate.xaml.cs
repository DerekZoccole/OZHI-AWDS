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
        DataTable dt2;

        double mat;
        double lab;

        string project = "Project / Client / Property: ";
        string clientID = "Client ID No.: ";
        string alternateName = "Alternate Name: ";
        string loanType = "Loan Type: ";
        string contact = "Contact Name: ";
        string telephone = "Telephone (Work): ";
        string address = "Address: ";
        string CMHCAccountNumber = "CMHC Account #: ";
        string legalDescription = "Legal Description: ";
        string agentReferenceNumber = "Agent Reference #: ";
        string city = "City / Province: ";
        string inspectionDate = "Inspection Date: ";
        string postalCode = "Postal Code: ";
        string inspector = "Tech. Officer: ";
        string itemCode = "Item Code";
        string workSpecification = "Work Item";
        string estimate = "Estimate";
        string materialEstimate = "Material Estimate: ";
        string labourEstimate = "Labour Estimate: ";

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
            dt.Columns.Add(new DataColumn("AgentReferenceNumber", typeof(string)));
            dt.Columns.Add(new DataColumn("City", typeof(string)));
            dt.Columns.Add(new DataColumn("Province", typeof(string)));
            dt.Columns.Add(new DataColumn("InspectionDate", typeof(string)));
            dt.Columns.Add(new DataColumn("PostalCode", typeof(string)));
            dt.Columns.Add(new DataColumn("Inspector1", typeof(string)));
            dt.Columns.Add(new DataColumn("Inspector2", typeof(string)));
            dt.Columns.Add(new DataColumn("ItemCode", typeof(string)));
            dt.Columns.Add(new DataColumn("WorkSpecification", typeof(string)));
            dt.Columns.Add(new DataColumn("Estimate", typeof(string)));

            dt2 = new DataTable();
            dt2.Columns.Add(new DataColumn("WorkNumber", typeof(string)));
            dt2.Columns.Add(new DataColumn("Priority", typeof(string)));
            dt2.Columns.Add(new DataColumn("Section", typeof(string)));
            dt2.Columns.Add(new DataColumn("Urgency", typeof(string)));
            dt2.Columns.Add(new DataColumn("WorkSpecificationDescription", typeof(string)));
            dt2.Columns.Add(new DataColumn("ImperialUnits", typeof(string)));
            dt2.Columns.Add(new DataColumn("MetricUnits", typeof(string)));
            dt2.Columns.Add(new DataColumn("ImperialDescription", typeof(string)));
            dt2.Columns.Add(new DataColumn("MetricDescription", typeof(string)));
            dt2.Columns.Add(new DataColumn("ImperialQuanity", typeof(string)));
            dt2.Columns.Add(new DataColumn("MetricQuanity", typeof(string)));
            dt2.Columns.Add(new DataColumn("MaterialEstimate", typeof(string)));
            dt2.Columns.Add(new DataColumn("LabourEstimate", typeof(string)));
            dt2.Columns.Add(new DataColumn("Total", typeof(double)));

            DataRow dr1 = dt.NewRow();
            dr1["Service"] = "RRAP";
            dr1["ServiceDescription"] = "Residential Rehabilitation Assistance Program";
            dr1["Project"] = project + "Address";
            dr1["ClientID"] = clientID + 1;
            dr1["AlternateName"] = alternateName + "Alternate Name";
            dr1["LoanType"] = loanType + "Homeowner";
            dr1["LoanTypeF"] = "";
            dr1["Contact"] = contact + "Contact Name";
            dr1["Telephone"] = telephone + "411";
            dr1["Address"] = address + "123 Fake Street";
            dr1["CMHCAccountNumber"] = CMHCAccountNumber + "111-111-111";
            dr1["LegalDescription"] = legalDescription + "";
            dr1["AgentReferenceNumber"] = agentReferenceNumber + "";
            dr1["City"] = city + "Thunder Bay";
            dr1["Province"] = "ON";
            dr1["InspectionDate"] = inspectionDate + "01/01/1900";
            dr1["PostalCode"] = postalCode + "A1A1A1";
            dr1["Inspector1"] = inspector + "Derek Zoccole";
            dr1["Inspector2"] = "";
            dr1["ItemCode"] = itemCode;
            dr1["WorkSpecification"] = workSpecification;
            dr1["Estimate"] = estimate;
            dt.Rows.Add(dr1);

            DataRow dr2 = dt2.NewRow();
            dr2["WorkNumber"] = "0 09260B";
            dr2["Priority"] = "Eligible";
            dr2["Section"] = "Section (7.2)";
            dr2["Urgency"] = "MEDIUM";
            dr2["WorkSpecificationDescription"] = "Supply labour and materials to install 12mm (1/2 inch) gypsum board to finish interior walls.  Joint fill tape and sand ready for painting.  Paint all wals and ceiling with primer sealer and 2 finish coats.  LOCATION: all rooms";
            dr2["ImperialUnits"] = "";
            dr2["MetricUnits"] = "";
            dr2["ImperialDescription"] = "";
            dr2["MetricDescription"] = "";
            dr2["ImperialQuanity"] = "";
            dr2["MetricQuanity"] = "";
            dr2["MaterialEstimate"] = materialEstimate + ConvertToCurrency(1200);
            dr2["LabourEstimate"] = labourEstimate + ConvertToCurrency(2750);
            mat = FindDouble(dr2["MaterialEstimate"]);
            lab = FindDouble(dr2["LabourEstimate"]);
            dr2["Total"] = mat + lab;
            dt2.Rows.Add(dr2);

            DataRow dr3 = dt2.NewRow();
            dr3["WorkNumber"] = "0 07210A";
            dr3["Priority"] = "Mandatory";
            dr3["Section"] = "Section (6.1)";
            dr3["Urgency"] = "HIGH";
            dr3["WorkSpecificationDescription"] = "Supply and install insulation to the attic area to min R-42.  Work to include installation of insulation stops at soffit vents, insulating shields around chimneys, and weatherstripping the attic hatch c/w roof vents.";
            dr3["ImperialUnits"] = "";
            dr3["MetricUnits"] = "";
            dr3["ImperialDescription"] = "";
            dr3["MetricDescription"] = "";
            dr3["ImperialQuanity"] = "";
            dr3["MetricQuanity"] = "";
            dr3["MaterialEstimate"] = materialEstimate + ConvertToCurrency(1750);
            dr3["LabourEstimate"] = labourEstimate + ConvertToCurrency(1250);
            mat = FindDouble(dr3["MaterialEstimate"]);
            lab = FindDouble(dr3["LabourEstimate"]);
            dr3["Total"] = mat + lab;
            dt2.Rows.Add(dr3);

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            reportDataSource.Value = dt;

            ReportDataSource reportDataSource2 = new ReportDataSource();
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = dt2;

            reportViewerEstimate.LocalReport.ReportPath = "C:\\Users\\Derek Z\\documents\\visual studio 2015\\Projects\\OZHI-AWDS\\OZHI-AWDS\\Reports\\EstimateEng.rdlc";
            reportViewerEstimate.LocalReport.EnableExternalImages = true;
            reportViewerEstimate.LocalReport.DataSources.Add(reportDataSource);
            reportViewerEstimate.LocalReport.DataSources.Add(reportDataSource2);
            reportViewerEstimate.RefreshReport();
        }

        private string ConvertToCurrency(int v)
        {
            string s = (v / 1m).ToString("C2");

            return s;
        }

        private double FindDouble(object v)
        {
            string s = (string)v;
            string sub;
            int index = s.LastIndexOf(' ') + 1;

            // Find substring of last whitespace to isolate number
            sub = s.Substring(index);

            // Remove $

            // Remove ,

            // Return double
            Console.WriteLine(sub);

            return 0.0;
        }
    }
}
