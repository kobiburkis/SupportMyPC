using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SupportMyPC.Models
{
    public class SupportCall
    {
        public int SupportCallId { get; set; }
        public string CustID { get; set; }
        [Required(ErrorMessage = "הזן שם לקוח")]
        public string CustName { get; set; }
        public string CustEmail { get; set; }
        [Required(ErrorMessage = "הזן טלפון")]
        public string CustPhone { get; set; }
        public bool? RegisteredCust { get; set; }
        public string ProblemMachine { get; set; }
        [Required(AllowEmptyStrings =false, ErrorMessage = "לא נבחר ערך")]
        public int ProblemMachineID { get; set; }
        public string ProblemDescription { get; set; }
        public string SupportCallDate { get; set; }
        public DateTime SupportCallTreatDate { get; set; }
        public int SupportCallStatusID { get; set; }
        public string SupportCallStatus { get; set; }
    }
}
