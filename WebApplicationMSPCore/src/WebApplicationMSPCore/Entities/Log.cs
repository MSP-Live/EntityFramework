using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationMSPCore.Entities
{
    [Table("Logs")]
    public class Log : BaseEntity
    {
        public string Ip { get; set; }
        public DateTime Date { get; set; }
    }
}
