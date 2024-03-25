namespace cw3;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool contentsSafe { get; set; }

    public LiquidContainer(double maxLoad, double cargoMass, double height, double containerWeight, double depth,
        string serial, bool contentsSafe) : base(maxLoad, cargoMass, height, containerWeight, depth, serial)
    {
        this.contentsSafe = contentsSafe;
    }

    public void Notify()
    {
        Console.WriteLine("Niebezpieczna sytuacja!");
    }

    public void Notify(string message)
    {
        Console.WriteLine("Niebezpieczna sytuacja: " + message);
    }

    public override void Load(double mass)
    {
        Load(mass, true);
    }

    public void Load(double mass, bool safe)
    {
        if (contentsSafe ^ safe)
        {
            Notify("mieszanie niebezpiecznego ładunku z bezpiecznym!");
            return;
        }

        if (!safe && cargoMass + mass > 0.5 * maxLoad)
        {
            Notify("masa niebezpiecznego ladunku przekracza 50% pojemności!");
            return;
        }

        if (safe && cargoMass + mass > 0.9 * maxLoad)
        {
            Notify("masa bezpiecznego ladunku przekracza 90% pojemności!");
            return;
        }

        base.Load(mass);
    }
}