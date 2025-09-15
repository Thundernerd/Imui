using System;
using System.Diagnostics;
using UnityEngine;

// ReSharper disable CheckNamespace

internal class ImuiAssertException: Exception
{
    public ImuiAssertException(string message): base(message) { }
}

internal static class ImAssert
{
    [HideInCallstack]
    [Conditional("IMUI_DEBUG")]
    public static void IsTrue(bool value, string message)
    {
        if (!value)
        {
            throw new ImuiAssertException(message);
        }
    }

    [HideInCallstack]
    [Conditional("IMUI_DEBUG")]
    public static void IsFalse(bool value, string message)
    {
        if (value)
        {
            throw new ImuiAssertException(message);
        }
    }
}