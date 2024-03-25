namespace cw3;

public class GasContainer : Container, IHazardNotifier
{
    public GasContainer(double maxLoad, double cargoMass, double height, double containerWeight, double depth,
        string serial) : base(maxLoad, cargoMass, height, containerWeight, depth, serial)
    {
    }

    public override void Unload()
    {
        this.cargoMass = this.cargoMass * 0.05;
    }

    public void Notify()
    {
        Notify("Nr. seryjny kontenera: " + serial);
    }

    public void Notify(string message)
    {
        Console.WriteLine("Niebezpieczna sytuacja! " + message);
    }
}