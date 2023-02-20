namespace PrototypeBilder
{
    // Конкретний клас прототипу будівлі
    public class ConcreteBuildingPrototype : BuildingPrototype
    {
        public override BuildingPrototype Clone()
        {
            // Клонуємо об'єкт, використовуючи глибоке копіювання
            return (BuildingPrototype)this.MemberwiseClone();
        }
    }
}
