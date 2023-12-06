/* 
* Prototype (생성 패턴)
* - 기존 인스턴스를 복제하여 새로운 인스턴스를 만드는 방법
* - 복제 기능을 갖추고 있는 기존 인스턴스를 프로토타입으로 사용해 새 인스턴스를 만들 수 있다.
* - 인스턴스를 만들 때마다 많은 리소스를 요하는 경우 효과적이다.
*/


public interface IPrototype<T>
{
    T Clone();
}

public class ConcretePrototype(int id, string name) : IPrototype<ConcretePrototype>
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;

    public ConcretePrototype Clone() => (ConcretePrototype)this.MemberwiseClone(); // shallow copy임을 명심.
}





