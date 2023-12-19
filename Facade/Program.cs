/* 
* Facade (구조 패턴)
* - 복잡한 서브 시스템 의존성을 최소화하는 방법
* - 클라이언트가 사용해야 하는 복잡한 서브 시스템 의존성을 간단한 인터페이스로 추상화 할 수 있다.
*/

public class Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
{
    private readonly Subsystem1 _subsystem1 = subsystem1;
    private readonly Subsystem2 _subsystem2 = subsystem2;

    public string Operation()
    {
        string result = "Facade initializes subsystems:\n";
        result += _subsystem1.operation1();
        result += _subsystem2.operation1();
        result += "Facade orders subsystems to perform the action:\n";
        result += _subsystem1.operationN();
        result += _subsystem2.operationZ();
        return result;
    }
}

public class Subsystem1
{
    public string operation1()
    {
        return "Subsystem1: Ready!\n";
    }

    public string operationN()
    {
        return "Subsystem1: Go!\n";
    }
}

public class Subsystem2
{
    public string operation1()
    {
        return "Subsystem2: Get ready!\n";
    }

    public string operationZ()
    {
        return "Subsystem2: Fire!\n";
    }
}