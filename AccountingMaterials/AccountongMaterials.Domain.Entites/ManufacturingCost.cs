using System.ComponentModel.DataAnnotations;

namespace AccountingMaterials.Domain.Entites
{
    public class ManufacturingCost
    {
        public long Id { get; set; }

        [StringLength(60)]
        public string Name { get; set; }
    }
}
