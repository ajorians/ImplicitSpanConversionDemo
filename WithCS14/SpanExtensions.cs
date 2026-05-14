using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace WithCS14
{
    public static class SpanExtensions
    {
        public static void ShowLengthExt<T>( this ReadOnlySpan<T> span)
        {
            Console.WriteLine(span.Length);
        }
    }
}
