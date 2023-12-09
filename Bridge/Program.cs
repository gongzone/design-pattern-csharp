/* 
* Bridge (구조 패턴)
* - 추상적인 것과 구체적인 것을 분리하여 연결하는 패턴
* - 하나의 계층 구조일 때 보다 각기 나누었을 때 독립적인 계층 구조로 발전 시킬 수 있다.
*/

class Abstraction(IImplementation implementation)
{
    protected IImplementation _implementation = implementation;

    public virtual string Operation()
    {
        return $"Abstarcton: {_implementation.OperationImplementation()}";
    }
}

class ExtendedAbstraction(IImplementation implementation) : Abstraction(implementation)
{
    public override string Operation()
    {
        return $"ExtendedAbstraction: {base._implementation.OperationImplementation()}";
    }
}

public interface IImplementation
{
    string OperationImplementation();
}

class ConcreteImplementaionA : IImplementation
{
    public string OperationImplementation()
    {
        return "ConcreteImplementaionA";
    }
}

class ConcreteImplementationB : IImplementation
{
    public string OperationImplementation()
    {
        return "ConcreteImplementationB";
    }
}