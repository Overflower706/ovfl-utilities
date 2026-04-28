using UnityEngine;

public abstract class LazySceneSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                var go = new GameObject(typeof(T).Name);
                instance = go.AddComponent<T>();
            }
            return instance;
        }
    }

    private static T instance;

    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    protected virtual void OnDestroy()
    {
        if (instance == this)
        {
            instance = null;
        }
    }
}
