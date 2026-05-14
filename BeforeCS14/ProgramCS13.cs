using BeforeCS14;

static void ShowLength<T>(ReadOnlySpan<T> span)
{
    Console.WriteLine(span.Length);
}

ReadOnlySpan<int> onStack = stackalloc int[] { 1, 2, 3, 4, 5 };
ShowLength(onStack);

ReadOnlySpan<char> text = "Hello, World!";
ShowLength(text);
ShowLength(text[0..5]);

int[] array = [1, 2, 3, 4, 5];
ReadOnlySpan<int> readOnlySpan = array;
ShowLength(readOnlySpan);

readOnlySpan.ShowLengthExt();















//object[] strings = ["one", "two", "three"];
//ReadOnlySpan<object> x = strings;
//WithImplicit i = x;

//public class WithImplicit
//{
//    public static implicit operator WithImplicit(ReadOnlySpan<object> s)
//    {
//        return new();
//    }
//}