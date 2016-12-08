using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationMSP.Entities
{
    [Table("Logs")]
    public class Log : BaseEntity
    {
        public string Ip { get; set; }
        public DateTime Date { get; set; }
    }
}