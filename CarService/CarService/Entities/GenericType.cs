using System.ComponentModel.DataAnnotations;

namespace CarCore.Entities
{
    public class GenericType
    {
        [Key]
        public long ID { set; get; }
        public string Name { set; get; } = string.Empty;
    }
}
