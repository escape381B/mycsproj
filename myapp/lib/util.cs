using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("myapp.test")]
namespace myapp.lib
{
   internal class calculator
    {
        internal int Add(int x, int y) => x + y;
    }
}