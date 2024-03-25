namespace cw3;

public class ContainerShip
{
    public Container?[] containers { get; }
    private int _containersStored;
    public double maxSpeed { get; set; }

    public int maxContainers { get; }

    public double maxContainersWeight { get; }
    private double _currWeight = 0;

    public ContainerShip(double maxSpeed, int maxContainers, double maxContainersWeight)
    {
        this.maxSpeed = maxSpeed;
        this.maxContainers = maxContainers;
        this.maxContainersWeight = maxContainersWeight;
        this.containers = new Container?[maxContainers];
        this._containersStored = 0;
    }

    public void LoadContainer(Container container)
    {
        if (_containersStored >= maxContainers)
        {
            throw new Exception("Za duzo kontenerow na statku!");
        }

        containers[_containersStored] = container;
        _containersStored += 1;
    }

    public void LoadContainerList(Container[] containers)
    {
        foreach (var a in containers)
        {
            LoadContainer(a);
        }
    }

    public Container? PopContainer()
    {
        if (_containersStored == 0)
        {
            return null;
        }

        Container toReturn = containers[_containersStored]!;
        containers[_containersStored] = null;
        _containersStored--;
        return toReturn;

    }
}