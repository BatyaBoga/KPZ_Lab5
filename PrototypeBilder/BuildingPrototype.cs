

namespace PrototypeBilder
{
    // Базовий клас прототипу будівлі
    public abstract class BuildingPrototype
    {
        public string Name { get; set; }
        public int Floors { get; set; }
        public double Area { get; set; }

        public abstract BuildingPrototype Clone();
    }
}
