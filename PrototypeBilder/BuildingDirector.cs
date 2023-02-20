namespace PrototypeBilder
{
    // Клас-директор для будівельника
    public class BuildingDirector
    {
        private BuildingPrototype _buildingPrototype;

        public BuildingDirector(BuildingPrototype buildingPrototype)
        {
            this._buildingPrototype = buildingPrototype;
        }

        public void SetName(string name)
        {
            this._buildingPrototype.Name = name;
        }

        public void SetFloors(int floors)
        {
            this._buildingPrototype.Floors = floors;
        }

        public void SetArea(double area)
        {
            this._buildingPrototype.Area = area;
        }

        public BuildingPrototype GetBuilding()
        {
            return this._buildingPrototype.Clone();
        }
    }
}
