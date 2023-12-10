/* 
* Decorator (구조 패턴)
* - 기존 코드를 변경하지 않고 부가 기능을 추가하는 패턴.
* - 상속이 아닌 위임을 사용해서 보다 유연하게(런타임) 부가 기능을 추가하는 것도 가능하다.
*/

public abstract class Component
{
    public abstract string Operation();
}

class ConcreteComponent : Component
{
    public override string Operation()
    {
        return "ConcreteComponent";
    }
}


abstract class Decorator(Component component) : Component
{
    protected Component _component = component;

    public override string Operation()
    {
        return _component.Operation();
    }
}

class ConcreteDecoratorA(Component component) : Decorator(component)
{
    public override string Operation()
    {
        return $"ConcreteDecoratorA({base.Operation()})";
    }
}

class ConcreteDecoratorB(Component component) : Decorator(component)
{
    public override string Operation()
    {
        return $"ConcreteDecoratorB({base.Operation()})";
    }
}