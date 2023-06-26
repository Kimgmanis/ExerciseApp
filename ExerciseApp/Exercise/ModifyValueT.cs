using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseApp.Exercise
{
    internal class ModifyValueT
    {
        // Define params; ref to int a, read-only b, out-put integer
        public static void ModifyValue(ref int a, in int b, out int c)
        {
            a += b; // b + a
            c = a - b; // b - a = c
        }

        public ModifyValueT() 
        {
            int x = 10;
            int y = 5;
            int z;

            Console.WriteLine($"Before calling ModifyValue: x={x}, y={y}");

            ModifyValue(ref x, y, out z);

            Console.WriteLine($"After calling ModifyValue: x={x}, z={z}");
        }

    }
}
