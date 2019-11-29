using System;

namespace HiCar.Logic.Entities
{
    public class Car : Entity
    {
        public virtual string Model { get; set; }
        public virtual string Registration { get; set; }
        public virtual long MeterSetting { get; set; }
        public virtual bool IsRented { get; set; }
    }
}