using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandupIndicators.Model
{
    public class Owner
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int DepartamentId { get; set; }

        [ForeignKey(nameof(DepartamentId))]
        public virtual Departament? Departament { get; set; }
    }
}
