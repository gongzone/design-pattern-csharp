/* 
* Builder (���� ����)
* - ������ ���μ����� ���� �پ��� ������ �ν��Ͻ��� ����� ���.
* - (������) ��ü�� ����� ���μ����� ���������� �и��� �� �ִ�.
*/

interface IBuilder
{
    IBuilder BuildPartA();
    IBuilder BuildPartB();
    IBuilder BuildPartC();
    Product getProduct();
}

class ConcreteBuilder : IBuilder
{
    private readonly string _partA;
    private readonly string _partB; 
    private readonly string _partC; 

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

    public getProduct()
    {
        return new Product(_partA, _partB, _partC);
    }
}

class Product
{
    public string PartA { get; set; }
    public string PartB { get; set; }   
    public string? PartC { get; set; }

    public Product(string partA, string partB, string? partC)
    {
        PartA = partA;  
        PartB = partB;
        PartC = partC;  
    }
}

class Director
{
    private readonly IBuilder _builder;

    public Director(IBuilder builder) 
    {
        _builder = builder;
    }

    public Product CreateProductWithAllParts()
    {
        return _builder
                .BuildPartA("partA")
                .BuildPartB("partB")
                .BuildPartC("partC")
                .getProduct();
    }

    public Product CreateProductWithAAndB()
    {
        return _builder
                .BuildPartA("partA")
                .BuildPartB("partB")
                .getProduct();
    }
}


