namespace OOP.Events.KingsGambit.EventArgs
{
    using System;

    public class HeroEventArgs : EventArgs
    {
        public HeroEventArgs(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
    }
}
