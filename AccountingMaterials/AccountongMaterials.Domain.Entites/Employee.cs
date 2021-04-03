using System.ComponentModel.DataAnnotations;

namespace AccountingMaterials.Domain.Entites
{
    public class Employee
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(150)]
        public string Position { get; set; }
    }
}
