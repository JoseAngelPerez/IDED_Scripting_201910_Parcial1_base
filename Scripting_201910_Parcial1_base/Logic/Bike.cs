﻿namespace Scripting_201910_Parcial1_base.Logic
{
    public class Bike : Vehicle
    {
        public Muffler muffler = new Muffler();
        public Turbo turbo = new Turbo();
        public Bike() : base()
        {
        }

        public Bike(float _baseMaxSpeed) : base(_baseMaxSpeed)
        {
        }

        protected override VehicleType Type
        {
            get
            {
                return VehicleType.None;
            }
        }
    }
}