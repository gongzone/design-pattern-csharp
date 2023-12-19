/* 
* Flyweight (구조 패턴)
* - 객체를 가볍게 만들어 메모리 사용을 줄이는 패턴
* - 자주 변하는 속성 (또는 외적인 속성, extrinsit)과 변하지 않는 속성 (또는 내적인 속성, intrinsit)을
*   분리하고 재사용하여 메모리 사용을 줄일 수 있다.
*/

// Flyweight interface
public interface ICharacter
{
    void Display();
}

// Concrete flyweight class
public class Character(char symbol, int size, string font) : ICharacter
{
    private readonly char _symbol = symbol;
    private readonly int _size = size;
    private readonly string _font = font;

    public void Display()
    {
        Console.WriteLine($"Symbol: {_symbol}, Size: {_size}, Font: {_font}");
    }
}

// Flyweight factory class
public class CharacterFactory
{
    private readonly Dictionary<string, ICharacter> _characters = new();

    public ICharacter GetCharacter(char symbol, int size, string font)
    {
        var key = symbol.ToString() + size.ToString() + font;

        if (!_characters.ContainsKey(key))
        {
            _characters.Add(key, new Character(symbol, size, font));
        }

        return _characters[key];
    }
}