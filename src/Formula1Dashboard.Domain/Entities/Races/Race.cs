using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Formula1Dashboard.Entities.Races
{
    [Table("Race", Schema = "dbo")]
    public class Race : Entity<int>
    {
        public int Year { get; set; }
        public int Round { get; set; }
        public int CircuitId { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public string Time { get; set; }
        public string Url { get; set; }
        [Column("fp1_date")]
        public string Fp1_Date { get; set; }
        [Column("fp2_date")]
        public string Fp2_Date { get; set; }
        [Column("fp3_date")]
        public string Fp3_Date { get; set; }
        [Column("fp1_time")]
        public string Fp1_Time { get; set; }
        [Column("fp2_time")]
        public string Fp2_Time { get; set; }
        [Column("fp3_time")]
        public string Fp3_Time { get; set; }
        [Column("quali_date")]
        public string Quali_Date { get; set; }
        [Column("sprint_date")]
        public string Sprint_Date { get; set; }
        [Column("quali_time")]
        public string Quali_Time { get; set; }
        [Column("sprint_time")]
        public string Sprint_Time { get; set; }
    }
}
