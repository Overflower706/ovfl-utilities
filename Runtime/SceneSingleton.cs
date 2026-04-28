using UnityEngine;

/// <summary>
/// 씬에 미리 배치된 MonoBehaviour 싱글톤 기반 클래스.
/// Instance는 씬에 오브젝트가 배치된 후에만 유효합니다.
/// 씬 배치 전 또는 씬 전환 후에는 null을 반환할 수 있습니다.
/// </summary>
public abstract class SceneSingleton<T> : MonoBehaviour where T : SceneSingleton<T>
{
    private static T _instance;

    /// <summary>
    /// 씬에 배치된 인스턴스를 반환합니다. 배치 전 또는 씬 전환 후에는 null일 수 있습니다.
    /// </summary>
    public static T Instance => _instance;

    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    protected virtual void OnDestroy()
    {
        if (_instance == this)
        {
            _instance = null;
        }
    }
}
