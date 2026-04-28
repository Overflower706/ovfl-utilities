using System.Diagnostics;

public class DebugEx
{
    [Conditional("UNITY_EDITOR")]
    public static void Log(object message, UnityEngine.Object context = null)
    {
        UnityEngine.Debug.Log(message, context);
    }

    [Conditional("UNITY_EDITOR")]
    public static void LogWarning(object message, UnityEngine.Object context = null)
    {
        UnityEngine.Debug.LogWarning(message, context);
    }

    [Conditional("UNITY_EDITOR")]
    public static void LogError(object message, UnityEngine.Object context = null)
    {
        UnityEngine.Debug.LogError(message, context);
    }
}
