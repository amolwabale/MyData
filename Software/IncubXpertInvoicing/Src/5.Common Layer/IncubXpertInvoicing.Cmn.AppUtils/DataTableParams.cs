using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IncubXpertInvoicing.Cmn.AppUtils
{
    public class DataTableRequest
    {
       
        public int draw { get; set; }

        public int start { get; set; }

        public int length { get; set; }
    }

    public class DataTableResponse
    {
        public int draw { get; set; }

        public int recordsTotal { get; set; }

        public int recordsFiltered { get; set; }

        public List<string[]> data { get; set; }

        public string error { get; set; }
    }
}
