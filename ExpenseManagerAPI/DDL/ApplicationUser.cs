using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ExpenseManagerAPI.DDL
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Expenses = new HashSet<Expense>();
        }

        [Column(TypeName = "nvarchar(150)")] public string FullName { get; set; }
        public ICollection<Expense> Expenses { get; set; }
    }
}