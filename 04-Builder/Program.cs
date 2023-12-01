/* 
* Builder (생성 패턴)
* - 동일한 프로세스를 거쳐 다양한 구성의 인스턴스를 만드는 방법.
* - (복잡한) 객체를 만드는 프로세스를 독립적으로 분리할 수 있다.
*/

interface IBuilder
{
    IBuilder BuildPartA(string partA);
    IBuilder BuildPartB(string partB);
    IBuilder BuildPartC(string partC);
    Product GetProduct();
}

class ConcreteBuilder : IBuilder
{
    private string _partA = string.Empty;
    private string _partB = string.Empty;
    private string _partC = string.Empty;

    public IBuilder BuildPartA(string partA)
    {
        _partA = partA;
        return this;
    }

    public IBuilder BuildPartB(string partB)
    {
        _partB = partB;
        return this;
    }

    public IBuilder BuildPartC(string partC)
    {
        _partC = partC;
        return this;
    }

    public Product GetProduct()
    {
        return new Product(_partA, _partB, _partC);
    }
}

class Product(string partA, string partB, string? partC)
{
    public string PartA { get; set; } = partA;
    public string PartB { get; set; } = partB;
    public string? PartC { get; set; } = partC;
}

class Director(IBuilder builder)
{
    private readonly IBuilder _builder = builder;

    public Product CreateProductWithAllParts()
    {
        return _builder
                .BuildPartA("partA")
                .BuildPartB("partB")
                .BuildPartC("partC")
                .GetProduct();
    }

    public Product CreateProductWithAAndB()
    {
        return _builder
                .BuildPartA("partA")
                .BuildPartB("partB")
                .GetProduct();
    }
}


