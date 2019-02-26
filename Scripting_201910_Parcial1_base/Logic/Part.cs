namespace Scripting_201910_Parcial1_base.Logic
{
    public abstract class Part
    {
        protected float speedBonus;
        protected float durability;

        private float PorcentajeBonus = 0.03f;


        public int Level { get; protected set; }
        public abstract VehicleType Type { get; }

        public float SpeedBonus
        {
            get { return 0F; }
            protected set { speedBonus = value; }
        }

       public float Durability
        {
            get { return 0f; }
            protected set { durability = value; }
        }

        public Part()
        {
        }

        public Part(float speedBonus, float durability)
        {
            SpeedBonus = speedBonus* Durability;
            Durability = durability;

        }

        public void Upgrade()
        {
            speedBonus = speedBonus + (speedBonus * PorcentajeBonus);
            Level++;
        }
    }
}