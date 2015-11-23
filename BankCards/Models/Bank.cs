using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankCards.Models
{
    public class Bank
    {
        public int BankId { get; set; }

        [Required()]
        [Display (Name = "Bank")]
        public String BankName { get; set; }

        public virtual List<Client> Clients { get; set; }
    }
}