using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BankCards.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        public int BankId { get; set; }
        public virtual Bank Bank {get; set;}

        [Display (Name = "Name")]
        public string ClientName { get; set; }

        [Display(Name = "Email")]
        [DataType (DataType.EmailAddress)]
        public string ClientEmail { get; set; }

        public virtual List<Card> Cards { get; set; }
    }
}