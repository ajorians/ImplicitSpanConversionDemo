public record Stringable
{
    public static implicit operator string(Stringable s)
    {
        return "";
    }
}























public record Stringableable
{
    public static implicit operator Stringable(Stringableable s)
    {
        return new Stringable();
    }
}