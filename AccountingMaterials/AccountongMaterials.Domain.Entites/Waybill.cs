using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingMaterials.Domain.Entites
{
    public class Waybill
    {
        public long Id { get; set; }

        [ForeignKey("MaterialID")]
        public Materials Material { get; set; }

        [ForeignKey("UnitID")]
        public Unit Unit { get; set; }

        public long RequiredCount { get; set; }
        public long ReleasedCount { get; set; }

        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }

        public long DocumentNumber { get; set; }
    }
}
