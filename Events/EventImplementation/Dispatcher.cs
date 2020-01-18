namespace OOP.Events.EventImplementation
{
    using System;

    public delegate void NameChangeEventHandler();

    public class Dispatcher
    {
        private string name;

        public event EventHandler<NameChangeEventArgs> NameChange;

        public string Name
        {
            get => this.name;
            set
            {
                this.NameChange?.Invoke(this, new NameChangeEventArgs(value));
                this.name = value;
            }
        }
    }
}
