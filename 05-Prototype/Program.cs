/* 
* Prototype (���� ����)
* - ���� �ν��Ͻ��� �����Ͽ� ���ο� �ν��Ͻ��� ����� ���
* - ���� ����� ���߰� �ִ� ���� �ν��Ͻ��� ������Ÿ������ ����� �� �ν��Ͻ��� ���� �� �ִ�.
* - �ν��Ͻ��� ���� ������ ���� ���ҽ��� ���ϴ� ��� ȿ�����̴�.
*/


public interface IPrototype<T>
{
    T Clone();
}

public class ConcretePrototype(int id, string name) : IPrototype<ConcretePrototype>
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;

    public ConcretePrototype Clone() => (ConcretePrototype)this.MemberwiseClone(); // shallow copy���� ���.
}





