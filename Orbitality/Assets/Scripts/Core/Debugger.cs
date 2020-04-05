using UnityEngine;

public static class Debugger
{
    public static void Log(object message, Object context = null, string color = "white")
    {
#if DEBUGGER
        Debug.Log($"<color={color}>{message}</color>", context);
#endif
    }
    public static void LogError(object message, Object context = null, string color = "white")
    {
#if DEBUGGER
        Debug.LogError($"<color={color}>{message}</color>", context);
#endif
    }
    public static void LogWarning(object message, Object context = null, string color = "white")
    {
#if DEBUGGER
        Debug.LogWarning($"<color={color}>{message}</color>", context);
#endif
    }
}