/* 
* FactoryMethod (생성 패턴)
* - 구체적으로 어떤 인스턴스를 만들지는 서브 클래스가 정한다.
* - 다양한 구현체(Product)가 있고, 그 중에서 특정한 구현체를 만들 수 있는 다양한 팩토리(Creator)를
*   제공할 수 있다.
*/


abstract class Creator
{
    public abstract IProduct CreateProduct();

    // core business logic
    public void SomeOperation()
    {
        var product = CreateProduct();
        var result = product.Operation();

        Console.WriteLine(result);  
    }
}

class ConcreteCreator1 : Creator
{
    public override IProduct CreateProduct()
    {
        return new ConcreteProduct1();
    }
}

class ConcreteCreator2 : Creator
{
    public override IProduct CreateProduct()
    {
        return new ConcreteProduct2();
    }
}

public interface IProduct
{
    string operation();
}

class ConcreteProduct1 : IProduct
{
    public string operation()
    {
        return "ConcreteProduct1 Operation..."
    }
}

class ConcreteProduct2 : IProduct
{
    public string operation()
    {
        return "ConcreteProduct2 Operation..."
    }
}
