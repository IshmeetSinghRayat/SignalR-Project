using System;
using System.Collections.Generic;
using System.Text;

namespace WorkOrderCore.Model
{
    public class JobcardTransactionsViewModel
    {
        public short Id { get; set; }
        public int JobCardId { get; set; }
        public int JobActivityId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFullName { get; set; }
        public string ActivityName { get; set; }
        public string JobName { get; set; }
        public string JobNumber { get; set; }
        public DateTime JobCardsTransactionsStartDate { get; set; }
        public DateTime JobCardsTransactionsEndDate { get; set; }
        public string JobCardsTransactionsStatus { get; set; }
        public string JobCardsTransactionsRemarks { get; set; }
        public DateTime? JobCardsTransactionsClosedAt { get; set; }
        public short? PrioritySequence { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string EmployeeTransactionStatus { get; set; }
    }
}
