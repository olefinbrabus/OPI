using static System.Console;

public class Program
{
    static void Main()
    {
        Material gold = new Material(1500m, "Gold", 5.37);
        WriteLine(gold);
        Material plastic = new Material(15m, "Plastic", 20);
        WriteLine(plastic);

    }
}

public abstract class MyProduct
{
    public abstract decimal ProductCost { get; set; }

    public abstract string Name {get; set;}
    
    public abstract double Weight { get; set; }
    
    
}

public class Material : MyProduct
{
    private decimal _productCost;  
    private string _name;  
    private double _weight;  
    
    public Material(decimal productCost, string name, double weight)
    {
        _productCost = productCost;
        _name = name;
        _weight = weight;
    }
    
    public override decimal ProductCost  
    {  
        get { return _productCost; }  
        set { _productCost = value; }  
    }
    
    public override string Name
    {  
        get { return _name; }  
        set { _name = value; }  
    }
    
    public override double Weight 
    {  
        get { return _weight; }  
        set { _weight = value; }  
    }

    public override string ToString()
    {
        return $"ProductCost = {ProductCost}, Name = {Name}, Weight = {Weight}";
    }
}
