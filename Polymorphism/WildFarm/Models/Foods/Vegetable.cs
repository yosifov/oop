﻿namespace OOP.Polymorphism.WildFarm.Models.Foods
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Vegetable : Food
    {
        public Vegetable(int quantity) 
            : base(quantity)
        {
        }
    }
}