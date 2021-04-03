using System.ComponentModel.DataAnnotations;

namespace AccountingMaterials.Domain.Entites
{
    public class Unit
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
