using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCore.Entities
{
    public class Car
    {
        [Key]
        public long ID { set; get; }
        public long BrandID { set; get; }
        public Brand Brand { set; get; }
        public long ModelID { set; get; }
        public ModelOfCar ModelOfCar { set; get; }
        public DateTime ManufacturingDate { set; get; }
        public int Miliage { set; get; }
        public long BodyTypeID { set; get; }
        public BodyType BodyType { set; get; }
        public long EngineTypeID { set; get; }
        public EngineType EngineType { set; get; }
        public double EngineVolume { set; get; }
        public long DriveTypeID { set; get; }
        public DriveType DriveType { set; get; }
        public long TransmissionTypeID { set; get; }
        public TransmissionType TransmissionType { set; get; }
    }
}
