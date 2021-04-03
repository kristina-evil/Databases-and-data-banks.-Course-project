using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingMaterials.Domain.Entites
{
    public class UseOfMatrials
    {
        public long Id { get; set; }

        [ForeignKey("MaterialID")]
        public Materials Material { get; set; }

        [ForeignKey("UnitID")]
        public Unit Unit { get; set; }

        public long MaterialCount { get; set; }

        [ForeignKey("ManufacturingCostID")]
        public ManufacturingCost ManufacturingCost { get; set; }

        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
    }
}
