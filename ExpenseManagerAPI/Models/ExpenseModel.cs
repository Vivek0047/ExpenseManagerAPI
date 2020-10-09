using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseManagerAPI.Models
{
    public class ExpenseModel
    {
        public int ExpenseId { get; set; }
        public long Amount { get; set; }
        public string ItemName { get; set; }
        public string Remarks { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
    }
}
