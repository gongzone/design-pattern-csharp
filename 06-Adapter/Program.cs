﻿/* 
* Adapter (구조 패턴)
* - 기존 코드를 클라이언트가 사용하는 인터페이스의 구현체로 바꿔주는 패턴
* - 클라이언트가 사용하는 인터페이스를 따르지 않는 기존 코드를 재사용할 수 있게 해준다.
*/

public interface ITarget
{
    string GetRequest();
}

class Adaptee
{
    public string GetSpecificRequest()
    {
        return "Specific Request";
    }
}

class Adapter(Adaptee adaptee) : ITarget
{
    private readonly Adaptee _adaptee = adaptee;

    public string GetRequest()
    {
        return $"This is '{_adaptee.GetSpecificRequest()}'";
    }
}