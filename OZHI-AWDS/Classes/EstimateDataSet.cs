﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZHI_AWDS.Classes
{
    public class EstimateDataSet
    {
        public string Service { get; set; }
        public string ClientID { get; set; }
        public string Project { get; set; }
        public string Address { get; set; }
        public string LegalDescription { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string LoanType { get; set; }
        public string LoanTypeF { get; set; }
        public string Telephone { get; set; }
        public string CMHCAccountNumber { get; set; }
        public string AgentReferenceNumber { get; set; }
        public string InspectionDate { get; set; }
        public string Inspector1 { get; set; }
        public string Inspector2 { get; set; }
        public class TablixClass
        {
            public string WorkSpecification { get; set; }
            public string Priority { get; set; }
            public string ImperialDescription { get; set; }
            public string MetricDescription { get; set; }
            public string ImperialQuanity { get; set; }
            public string MetricQuanity { get; set; }
            public string MaterialEstimate { get; set; }
            public string LabourEstimate { get; set; }
            public string WorkSpecificationDescription { get; set; }
        }
    }
}
