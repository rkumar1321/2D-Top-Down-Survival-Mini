using System.Diagnostics;
using UnityEngine;

public static class Logger {

    // Master Switch
    public static bool EnableLogs = true;

    [Conditional("UNITY_EDITOR")]
    [Conditional("DEVELOPMENT_BUILD")]
    public static void Log(string message) {
        if (!EnableLogs) return;

        UnityEngine.Debug.Log(message);
    }


    [Conditional("UNITY_EDITOR")]
    [Conditional("DEVELOPMENT_BUILD")]
    public static void LogError(string message) {
        if (!EnableLogs) return;

        UnityEngine.Debug.LogError(message);
    }


    [Conditional("UNITY_EDITOR")]
    [Conditional("DEVELOPMENT_BUILD")]
    public static void LogWarning(string message) {
        if (!EnableLogs) return;

        UnityEngine.Debug.LogWarning(message);
    }
}
