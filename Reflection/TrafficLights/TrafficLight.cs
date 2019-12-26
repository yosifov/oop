namespace OOP.Reflection.TrafficLights
{
    internal class TrafficLight
    {
        internal enum TrafficSignal
        {
            Red = 0,
            Green = 1,
            Yellow = 2
        }

        private TrafficSignal signal;

        public string Signal
        {
            get => this.signal.ToString();
            private set { TrafficSignal.TryParse(value, out this.signal); }
        }

        public void ToggleSignal()
        {
            var signals = typeof(TrafficSignal).GetEnumValues();
            this.signal = (TrafficSignal)signals.GetValue((int)(signal + 1) % signals.Length);
        }

        public override string ToString()
        {
            return this.Signal;
        }

        public TrafficLight(string signal)
        {
            this.Signal = signal;
        }
    }
}