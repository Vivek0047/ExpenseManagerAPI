using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseManagerAPI.DDL
{
    public class Expense
    {
        [Key] public int ExpenseId { get; set; }

        public long Amount { get; set; }
        public string ItemName { get; set; }
        public string Remarks { get; set; }
        public DateTime Date { get; set; }
        public ApplicationUser User { get; set; }
    }
}