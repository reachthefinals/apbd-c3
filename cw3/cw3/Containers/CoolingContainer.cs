using cw3.Enums;

namespace cw3;

public class CoolingContainer : Container
{
    public ECoolingProduct _storedProduct { get; }

    public double temperature
    {
        get { return temperature; }
        set
        {
            if (this.temperature < CoolingProductTemp.dict[_storedProduct])
            {
                throw new InvalidContainerException("Temperatura za niska!");
            }
        }
    }

    public CoolingContainer(double maxLoad, double cargoMass, double height, double containerWeight, double depth,
        string serial, ECoolingProduct storedProduct, double temp) : base(maxLoad, cargoMass, height, containerWeight,
        depth,
        serial)
    {
        this._storedProduct = storedProduct;
        this.temperature = temp;
        if (this.temperature < CoolingProductTemp.dict[_storedProduct])
        {
            throw new InvalidContainerException("Temperatura za niska!");
        }
    }

    public override void Load(double mass)
    {
        base.Load(mass);
    }
}