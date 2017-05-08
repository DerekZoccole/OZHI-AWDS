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
    /// Interaction logic for ReportViewerBid.xaml
    /// </summary>
    public partial class ReportViewerBid : Page
    {
        DataTable dt;
        DataTable dt2;
        DataTable dt3;

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

        string require = "NOTE: The following is a list of work items approved, by Canada Mortgage and Housing Corporation in" +
"\nconsultation with the owner, for rehabilitation under the RRAP(Residential Rehabilitation Assistance" +
"\nProgram)." +
"\n1) This list of work items may not be altered in any way without the prior written approval of CMHC." +
"\n2) In addition to the standards of construction referred to in this list, all work must meet the requirements of" +
"\nthe local authority having jurisdiction i.e.Provincial Building Code, Municipal By-laws, etc.." +
"\nIn the absence of such requirements, the requirements of the National Building Code of Canada 1995 shall be" +
"\nused as a guide." +
"\n3) All workmanship shall be carried out in accordance with industry standards and good construction" +
"\npractices." +
"\n4) All required certificates of approval or acceptance by local authorities must be provided to CMHC before" +
"\nfunds will be advanced." +
"\n5) Dimensions and quantities provided on this list of work items shall be considered approximate. The" +
"\ncontractor is responsible for confirming all dimensions and quantities on site." +
"\n6) The contractor shall remove, from the site, all extra fill and debris resulting from any of the work." +
"\n7) It is the responsibility of the contractor to request a job-site meeting prior to commencement of work to" +
"\ndiscuss any aspects of the work that may be unclear or, after work has started, should unexpected conditions" +
"\nbecome evident.";

        public ReportViewerBid()
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
            reportViewerBid.LocalReport.ReportPath = path + "\\Reports\\EstimateEng.rdlc";

            reportViewerBid.LocalReport.EnableExternalImages = true;
            reportViewerBid.LocalReport.DataSources.Add(reportDataSource);
            reportViewerBid.LocalReport.DataSources.Add(reportDataSource2);
            reportViewerBid.LocalReport.DataSources.Add(reportDataSource3);
            reportViewerBid.RefreshReport();
        }

        private void CreateBodyRows(DataTable dt1, DataTable dt2)
        {
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
            dr1["MaterialEstimate"] = "";
            dr1["LabourEstimate"] = "";
            dr1["Total"] = "";
            dt1.Rows.Add(dr1);

            DataRow dr2 = dt1.NewRow();
            dr2["WorkNumber"] = "0 07210A";
            dr2["Priority"] = "Mandatory";
            dr2["Section"] = "Section (6.1)";
            dr2["Urgency"] = "HIGH";
            dr2["WorkSpecificationDescription"] = "Remove existing stairs landing. Supply material and labour to install new wood landing and stairs conforming" +
"\nto the following dimensions:" +
"\nmaximum rise 8" +
"\n- minimum run 10" +
"\n- minimum tread 11." +
"\n- stair width to be 4" +
"\nWhere steps constitute more than 3 risers, a handrail shall be installed on one side if adjacent to wall and both" +
"\nsides if located at leading edge of landing.Railing construction shall conform to current code requirements." +
"\nMaximum landing size to be 6 by 8 feet.All material at building exterior or in contact with soil to be pressure" +
"\ntreated." +
"\nLOCATION: main and side entry";
            dr2["ImperialUnits"] = "";
            dr2["MetricUnits"] = "";
            dr2["ImperialDescription"] = "";
            dr2["MetricDescription"] = "";
            dr2["ImperialQuanity"] = "";
            dr2["MetricQuanity"] = "";
            dr2["MaterialEstimate"] = "";
            dr2["LabourEstimate"] = "";
            dr2["Total"] = "";
            dt1.Rows.Add(dr2);

            DataRow dr4 = dt1.NewRow();
            dr4["WorkNumber"] = "0 07210A";
            dr4["Priority"] = "Mandatory";
            dr4["Section"] = "Section (6.1)";
            dr4["Urgency"] = "HIGH";
            dr4["WorkSpecificationDescription"] = "Supply and install insulation to the attic area to min R-42.  Work to include installation of insulation stops at soffit vents, insulating shields around chimneys, and weatherstripping the attic hatch c/w roof vents.";
            dr4["ImperialUnits"] = "";
            dr4["MetricUnits"] = "";
            dr4["ImperialDescription"] = "";
            dr4["MetricDescription"] = "";
            dr4["ImperialQuanity"] = "";
            dr4["MetricQuanity"] = "";
            dr4["MaterialEstimate"] = "";
            dr4["LabourEstimate"] = "";
            dr4["Total"] = "";
            dt1.Rows.Add(dr4);

            DataRow dr3 = dt2.NewRow();
            dr3["TotalMaterial"] = "";
            dr3["TotalLabour"] = "";
            dr3["GrandTotal"] = "";
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
            dt2.Columns.Add(new DataColumn("GST", typeof(string)));
            dt2.Columns.Add(new DataColumn("PST", typeof(string)));
            dt2.Columns.Add(new DataColumn("Total", typeof(double)));

            dt3 = new DataTable();
            dt3.Columns.Add(new DataColumn("TotalMaterial", typeof(string)));
            dt3.Columns.Add(new DataColumn("TotalLabour", typeof(string)));
            dt3.Columns.Add(new DataColumn("TotalGST", typeof(string)));
            dt3.Columns.Add(new DataColumn("TotalPST", typeof(string)));
            dt3.Columns.Add(new DataColumn("GrandTotal", typeof(string)));
        }

        private string ConvertToCurrency(double v)
        {
            string s = v.ToString("C2");
            return s;
        }
    }
}
