namespace cw3;

public abstract class Container
{
    public double cargoMass { get; protected set; } //kg
    private double height { get; set; } // cm
    private double containerWeight { get; set; } // kg
    private double depth { get; set; } // cm
    protected string serial { get; set; } // KON-X-<NUM>
    protected double maxLoad { get; set; }

    protected Container(double maxLoad, double cargoMass, double height, double containerWeight, double depth, string serial)
    {
        this.maxLoad = maxLoad;
        this.cargoMass = cargoMass;
        this.height = height;
        this.containerWeight = containerWeight;
        this.depth = depth;
        this.serial = serial;
    }

    public virtual void Unload()
    {
        this.cargoMass = 0;
    }

    public virtual void Load(double mass)
    {
        if (cargoMass + mass > maxLoad)
        {
            throw new OverfillException();
        }
        else
        {
            cargoMass += mass;
        }
    }
}