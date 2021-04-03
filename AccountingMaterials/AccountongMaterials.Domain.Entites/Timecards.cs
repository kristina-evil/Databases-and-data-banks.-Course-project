using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingMaterials.Domain.Entites
{
    public class Timecards
    {
        public long Id { get; set; }

        [ForeignKey("MaterialID")]
        public Materials Material { get; set; }

        public DateTime Date { get; set; }
        public long DocumentNumber { get; set; }

        [StringLength(50)]
        public string FromWhom { get; set; }

        public int Income { get; set; }
        public int Outcome { get; set; }
    }
}
