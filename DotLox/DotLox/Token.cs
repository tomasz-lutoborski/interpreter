namespace DotLox;

public class Token
{
    readonly TokenType _type;
    readonly string _lexeme;
    readonly object? _literal;
    readonly int _line;

    public Token(TokenType type, string lexeme, object? literal, int line)
    {
        _type = type;
        _lexeme = lexeme;
        _literal = literal;
        _line = line;
    }

    public override string ToString()
    {
        return $"{_type} {_lexeme} {_literal}";
    }
}