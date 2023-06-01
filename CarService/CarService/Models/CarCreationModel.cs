using System.ComponentModel.DataAnnotations;

namespace CarServices.Core.Models
{
    public class CarCreationModel
    {
        [Required]
        public long BrandID { set; get; }
        [Required]
        public long ModelID { set; get; }
        [Required]
        public DateTime ManufacturingDate { set; get; }
        [Required]
        public int Miliage { set; get; }
        [Required]
        public long BodyTypeID { set; get; }
        [Required]
        public long EngineTypeID { set; get; }
        [Required]
        public double EngineVolume { set; get; }
        [Required]
        public long DriveTypeID { set; get; }
        [Required]
        public long TransmissionTypeID { set; get; }
    }
}
