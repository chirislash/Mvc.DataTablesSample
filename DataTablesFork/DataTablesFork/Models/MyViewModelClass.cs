using Mvc.JQuery.DataTables;
using System;
using System.Data;

namespace DataTablesFork.Models
{
    public class MyViewModelClass
    {
        [DataTables(Visible = false)]
        public int Id { get; set; }

        [DataTables(DisplayName = "PO-Number")]
        public string PONumber { get; set; }

        [DataTables(DisplayName = "Country")]
        public string CountryData { get; set; }

        [DataTables(DisplayName = "State")]
        public string State { get; set; }

        [DataTables(DisplayName = "Supplier")]
        public string Supplier { get; set; }

        [DataTables(DisplayName = "Postal Code")]
        public string PostalCode { get; set; }

        [DataTables(DisplayName = "Created by")]
        public string CreationUser { get; set; }

        [DataTables(DisplayName = "Creation Date")]
        public DateTime CreationDate { get; set; }

        [DataTables(DisplayName = "Last Update")]
        public DateTime StatusUpdateDate { get; set; }

        [DataTables(DisplayName = "Status")]
        public string Status { get; set; }

        [DataTables(DisplayName = "Actions")]
        public bool actions { get; set; }
    }
}