using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandupIndicators.Model
{
    public class Kpi
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public double Value { get; set; }
        [Required]
        public int KpiTypeId { get; set; }
        public string? Comment { get; set; }

        [ForeignKey(nameof(KpiTypeId))]
        public virtual KpiType? KpiType { get; set; }
    }
}
