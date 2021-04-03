using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingMaterials.Domain.Entites
{
    public class Materials
    {
        public long Id { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        public long Number { get; set; }

        [Column(TypeName="money")]
        public decimal Price { get; set; }
    }
}
