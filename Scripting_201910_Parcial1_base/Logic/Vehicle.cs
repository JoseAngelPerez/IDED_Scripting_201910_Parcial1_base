namespace Scripting_201910_Parcial1_base.Logic
{
    public abstract class Vehicle
    {
        protected float baseMaxSpeed;
        private float PorcentajeBonus=0.05f;
        private int UpgradeCount=0;
        protected int Level { get; set; }
         

        protected abstract VehicleType Type { get; }

        protected Part CurrentPart { get; set; }

        public float MaxSpeed
        {
            get
            {
                return 0F;
            }
        }

        public Vehicle()
        {
        }

        public Vehicle(float _baseMaxSpeed)
        {
            baseMaxSpeed = _baseMaxSpeed;
            Level = 0;
            CurrentPart = null;
            baseMaxSpeed = baseMaxSpeed + CurrentPart.SpeedBonus;
        }

        public bool Equip(Part part)
        {
            bool result = false;

            if (Type == part.Type || part.Type == VehicleType.Any)
            {
            }

            return result;
        }

        public void Upgrade()
        {
            if (UpgradeCount < 4)
            {
                baseMaxSpeed = baseMaxSpeed + (baseMaxSpeed * PorcentajeBonus);
                Level++;
                CurrentPart.Upgrade();
                UpgradeCount++;
            }
        }

        
    }
}