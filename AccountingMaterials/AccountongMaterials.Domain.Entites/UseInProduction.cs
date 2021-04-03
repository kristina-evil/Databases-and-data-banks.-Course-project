using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingMaterials.Domain.Entites
{
    public class UseInProduction
    {
        public long Id { get; set; }

        [ForeignKey("MaterialID")]
        public Materials Material { get; set; }

        [ForeignKey("UnitID")]
        public Unit Unit { get; set; }

        public long Remains { get; set; }
        public long RequiredCount { get; set; }
        public long ActualRise { get; set; }

        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
    }
}
