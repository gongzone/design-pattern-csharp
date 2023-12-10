/* 
* Composite (구조 패턴)
* - 그룹 전체와 개별 객체를 동일하게 처리할 수 있는 패턴.
* - 클라이언트 입장에서는 '전체'나 '부분'이나 모두 동일한 컴포넌트로 인식할 수 있는 계층 구조를 만든다.
* - Using the Composite pattern makes sense only when the core model of your app can be represented as a tree.
*/

abstract class Component
{
    public abstract string Operation();

    public virtual void Add(Component component)
    {
        throw new NotImplementedException();
    }

    public virtual void Remove(Component component)
    {
        throw new NotImplementedException();
    }

    public virtual bool IsComposite()
    {
        return true;
    }
}

class Leaf : Component
{
    public override string Operation()
    {
        return "Leaf";
    }

    public override bool IsComposite()
    {
        return false;
    }
}

class Composite : Component
{
    protected List<Component> _children = new List<Component>();

    public override void Add(Component component)
    {
        _children.Add(component);
    }

    public override void Remove(Component component)
    {
        _children.Remove(component);
    }

    public override string Operation()
    {
        string result = string.Empty;

        foreach (Component component in _children)
        {
            result = component.Operation() + "\n";
        }

        return result;
    }
}