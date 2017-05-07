using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
        DataTable dt3;

        double mat;
        double lab;
        double totalMaterial;
        double totalLabour;
        double grandTotal;

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
        string totalMaterial2 = "Total Estimate: ";
        string totalLabout2 = "Total Labour: ";
        string grandTotal2 = "Grand Total: ";

        public ReportViewerEstimate()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CreateDataTables();

            CreateHeaderRows(dt);

            CreateBodyRows(dt2, dt3);

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            reportDataSource.Value = dt;

            ReportDataSource reportDataSource2 = new ReportDataSource();
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = dt2;

            ReportDataSource reportDataSource3 = new ReportDataSource();
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = dt3;

            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            reportViewerEstimate.LocalReport.ReportPath = path + "\\Reports\\EstimateEng.rdlc";

            reportViewerEstimate.LocalReport.EnableExternalImages = true;
            reportViewerEstimate.LocalReport.DataSources.Add(reportDataSource);
            reportViewerEstimate.LocalReport.DataSources.Add(reportDataSource2);
            reportViewerEstimate.LocalReport.DataSources.Add(reportDataSource3);
            reportViewerEstimate.RefreshReport();
        }

        private void CreateBodyRows(DataTable dt1, DataTable dt2)
        {
            double m;
            double l;

            DataRow dr1 = dt1.NewRow();
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

            m = 1200.0;
            l = 2750.0;
            dr1["MaterialEstimate"] = materialEstimate + ConvertToCurrency(m);
            dr1["LabourEstimate"] = labourEstimate + ConvertToCurrency(l);
            totalMaterial += m;
            totalLabour += l;
            grandTotal += m + l;
            dr1["Total"] = m + l;
            dt1.Rows.Add(dr1);

            DataRow dr2 = dt1.NewRow();
            dr2["WorkNumber"] = "0 07210A";
            dr2["Priority"] = "Mandatory";
            dr2["Section"] = "Section (6.1)";
            dr2["Urgency"] = "HIGH";
            dr2["WorkSpecificationDescription"] = "Supply and install insulation to the attic area to min R-42.  Work to include installation of insulation stops at soffit vents, insulating shields around chimneys, and weatherstripping the attic hatch c/w roof vents.";
            dr2["ImperialUnits"] = "";
            dr2["MetricUnits"] = "";
            dr2["ImperialDescription"] = "";
            dr2["MetricDescription"] = "";
            dr2["ImperialQuanity"] = "";
            dr2["MetricQuanity"] = "";

            m = 1750.0;
            l = 1250.0;
            dr2["MaterialEstimate"] = materialEstimate + ConvertToCurrency(m);
            dr2["LabourEstimate"] = labourEstimate + ConvertToCurrency(l);
            totalMaterial += m;
            totalLabour += l;
            grandTotal += m + l;
            dr2["Total"] = m + l;
            dt1.Rows.Add(dr2);

            DataRow dr3 = dt2.NewRow();
            dr3["TotalMaterial"] = totalMaterial2 + ConvertToCurrency(totalMaterial);
            dr3["TotalLabour"] = totalLabout2 + ConvertToCurrency(totalLabour);
            dr3["GrandTotal"] = grandTotal2 + ConvertToCurrency(grandTotal);
            dt2.Rows.Add(dr3);
        }

        private void CreateHeaderRows(DataTable dt)
        {
            DataRow dr = dt.NewRow();
            dr["Service"] = "RRAP";
            dr["ServiceDescription"] = "Residential Rehabilitation Assistance Program";
            dr["Project"] = project + "Address";
            dr["ClientID"] = clientID + 1;
            dr["AlternateName"] = alternateName + "Alternate Name";
            dr["LoanType"] = loanType + "Homeowner";
            dr["LoanTypeF"] = "";
            dr["Contact"] = contact + "Contact Name";
            dr["Telephone"] = telephone + "411";
            dr["Address"] = address + "123 Fake Street";
            dr["CMHCAccountNumber"] = CMHCAccountNumber + "111-111-111";
            dr["LegalDescription"] = legalDescription + "";
            dr["AgentReferenceNumber"] = agentReferenceNumber + "";
            dr["City"] = city + "Thunder Bay";
            dr["Province"] = "ON";
            dr["InspectionDate"] = inspectionDate + "01/01/1900";
            dr["PostalCode"] = postalCode + "A1A1A1";
            dr["Inspector1"] = inspector + "Derek Zoccole";
            dr["Inspector2"] = "";
            dr["ItemCode"] = itemCode;
            dr["WorkSpecification"] = workSpecification;
            dr["Estimate"] = estimate;
            dt.Rows.Add(dr);
        }

        private void CreateDataTables()
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

            dt3 = new DataTable();
            dt3.Columns.Add(new DataColumn("TotalMaterial", typeof(string)));
            dt3.Columns.Add(new DataColumn("TotalLabour", typeof(string)));
            dt3.Columns.Add(new DataColumn("GrandTotal", typeof(string)));
        }

        private string ConvertToCurrency(double v)
        {
            string s = v.ToString("C2");
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
