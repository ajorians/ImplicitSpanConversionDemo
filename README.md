# ImplicitSpanConversionDemo
Demo for C# 14's Implicit Span Conversion.

First show differences with:
```csharp
ReadOnlySpan<int> onStack = stackalloc int[] { 1, 2, 3, 4, 5 };
ShowLength(onStack);
```

And then show before C# 14 that you couldn't do:
```csharp
ShowLength(stackalloc int[] { 1, 2, 3, 4, 5 });
```

But could if supply the template argument:
```csharp
ShowLength<int>(stackalloc int[] { 1, 2, 3, 4, 5 });
```

(Return back to slides)

Next bring up `implicit operator` and how it changed and you get one conversion.
```csharp
object[] strings = ["one", "two", "three"];
ReadOnlySpan<object> x = strings;
WithImplicit i = x;

public class WithImplicit
{
    public static implicit operator WithImplicit(ReadOnlySpan<object> s)
    {
        return new();
    }
}
```

(Return back to slides)

And how before C# 14 you needed to have the middle conversion variable.

Next show that only a single implicit conversion is allowed.  So given `Stringable` and how you can do:
```csharp
Stringable s = new();
string str = s;
```

You still have to do:
```csharp
Stringableable sa = new();
Stringable s = sa;
string str = s;
```


