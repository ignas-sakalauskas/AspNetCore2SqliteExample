using System.ComponentModel.DataAnnotations;

namespace dbtest
{
    public class MailCountSentErrorMails
    {
        [Key]
        public int Id {get;set;}
        public int CountSentMails { get; set; }
    }
}