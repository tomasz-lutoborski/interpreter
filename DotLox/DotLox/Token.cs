namespace DotLox;

public class Token
{
    readonly TokenType Type;
    readonly string Lexeme;
    readonly object Literal;
    readonly int Line;

    public Token(TokenType type, string lexeme, object literal, int line)
    {
        Type = type;
        Lexeme = lexeme;
        Literal = literal;
        Line = line;
    }

    public string ToString()
    {
        return $"{Type} {Lexeme} {Literal}";
    }
}