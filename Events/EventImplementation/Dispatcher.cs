namespace OOP.Events.EventImplementation
{
    using System;

    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);

    public class Dispatcher
    {
        private string name;

        public event NameChangeEventHandler NameChange;

        public string Name
        {
            get => this.name;
            set
            {
                this.OnNameChange(new NameChangeEventArgs(value));
                this.name = value;
            }
        }

        public void OnNameChange(NameChangeEventArgs args)
        {
            this.NameChange?.Invoke(this, args);
        }
    }
}
