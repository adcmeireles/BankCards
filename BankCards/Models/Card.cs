using System.ComponentModel.DataAnnotations;

namespace BankCards.Models
{
    public class Card
    {
        public int CardId { get; set; }

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        [DataType(DataType.CreditCard)]
        public string CardNumber { get; set; }

        [DataType(DataType.Date)]
        public System.DateTime ExpireDate { get; set; }

    }
}