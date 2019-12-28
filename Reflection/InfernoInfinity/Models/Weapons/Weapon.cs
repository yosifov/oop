namespace OOP.Reflection.InfernoInfinity.Models.Weapons
{
    using System;
    using System.Linq;
    using OOP.Reflection.InfernoInfinity.Contracts;
    using OOP.Reflection.InfernoInfinity.Enums;
    using OOP.Reflection.InfernoInfinity.Models.Gems;
    using OOP.Reflection.InfernoInfinity.Utilities;

    public abstract class Weapon : IWeapon, IGem
    {
        private readonly Gem[] gems;
        private string name;
        private int minDamage;
        private int maxDamage;
        private int sockets;
        private int strength;
        private int agility;
        private int vitality;

        protected Weapon(string name, int minDamage, int maxDamage, int sockets, Rarity rarity)
        {
            this.Name = name;
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
            this.Sockets = sockets;
            this.WeaponRarity = rarity;
            this.Strength = 0;
            this.Agility = 0;
            this.Vitality = 0;
            this.gems = new Gem[this.sockets];
        }

        public string Name
        {
            get => this.name;
            protected set
            {
                Validator.ValidateNullOrEmpty(value, nameof(this.Name));

                this.name = value;
            }
        }

        public int MinDamage
        {
            get => this.minDamage
                * (int)this.WeaponRarity
                + (this.Strength * 2)
                + (this.Agility * 1);
            
            protected set
            {
                Validator.ValidateNegative(value, nameof(this.MinDamage));

                this.minDamage = value;
            }
        }

        public int MaxDamage
        {
            get => this.maxDamage
                * (int)this.WeaponRarity
                + (this.Strength * 3)
                + (this.Agility * 4);
            
            protected set
            {
                Validator.ValidateNegative(value, nameof(this.MaxDamage));

                this.maxDamage = value;
            }
        }

        public int Sockets
        {
            get => this.sockets;
            protected set
            {
                Validator.ValidateNegative(value, nameof(this.Sockets));

                this.sockets = value;
            }
        }

        public Rarity WeaponRarity { get; protected set; }

        public int Strength
        {
            get => this.strength
                + this.gems.Where(x => x != null)
                .Sum(x => x.Strength);
            
            protected set
            {
                Validator.ValidateNegative(value, nameof(this.Strength));

                this.strength = value;
            }
        }

        public int Agility
        {
            get => this.agility
                + this.gems.Where(x => x != null)
                .Sum(x => x.Agility);
            
            protected set
            {
                Validator.ValidateNegative(value, nameof(this.Agility));

                this.agility = value;
            }
        }

        public int Vitality
        {
            get => this.vitality
                + this.gems.Where(x => x != null)
                .Sum(x => x.Vitality);
            
            protected set
            {
                Validator.ValidateNegative(value, nameof(this.Vitality));

                this.vitality = value;
            }
        }

        public void AddGem(int gemIndex, IGem gem)
        {
            if (gemIndex > this.gems.Length - 1 || gemIndex < 0)
            {
                throw new ArgumentException("Invalid weapon socket");
            }

            this.gems[gemIndex] = gem as Gem;
        }

        public void RemoveGem(int gemIndex)
        {
            if (gemIndex > this.gems.Length - 1 || gemIndex < 0)
            {
                throw new ArgumentException("Invalid weapon socket");
            }

            this.gems[gemIndex] = null;
        }

        public override string ToString()
        {
            return $"{this.Name}: " +
                $"{this.MinDamage}-{this.MaxDamage} Damage, " +
                $"+{this.Strength} Strength, " +
                $"+{this.Agility} Agility, " +
                $"+{this.Vitality} Vitality";
        }
    }
}
