using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modulo3 
{
    public static int modulo3(int x)
    {
        return (x % 3);
    }

    public static int[] modulo3(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = modulo3(xs[i]);
        }
        return result;
    }
}
