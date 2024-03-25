namespace cw3.Enums;

public enum ECoolingProduct
{
    Bananas,
    Chocolate,
    Fish,
    Meat,
    IceCream,
    FrozenPizza,
    Cheese,
    Sausages,
    Butter,
    Eggs
}

public static class CoolingProductTemp
{
    public static Dictionary<ECoolingProduct, double> dict = new Dictionary<ECoolingProduct, double>()
    {
        { ECoolingProduct.Bananas, 13.3 },
        { ECoolingProduct.Chocolate, 18 },
        { ECoolingProduct.Fish, 2 },
        { ECoolingProduct.Meat, -15 },
        { ECoolingProduct.IceCream, -18 },
        { ECoolingProduct.FrozenPizza, -30 },
        { ECoolingProduct.Cheese, 7.2 },
        { ECoolingProduct.Sausages, 5 },
        { ECoolingProduct.Butter, 20.5 },
        { ECoolingProduct.Eggs, 19 }
    };
}
