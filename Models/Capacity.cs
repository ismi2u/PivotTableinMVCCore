using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PivotTableinMVCCore.Models
{
    public class Capacity
    {

        [Key]
        public int CapacityID { get; set; }

    
        public string TeamStream { get; set; }



        public string ResourceName { get; set; }


  
        public string ProjectName { get; set; }


        public string ClarityCode { get; set; }


        public string ILCCode { get; set; }

        public Nullable<DateTime> ProjectStartDt { get; set; }

        [DataType(DataType.Date)]
        public Nullable<DateTime> ProjectEndDt { get; set; }


        public string ProjStatus { get; set; }


        public Nullable<DateTime> ClarityWeek { get; set; }

        public int? PlannedEffort { get; set; }

    }
}
