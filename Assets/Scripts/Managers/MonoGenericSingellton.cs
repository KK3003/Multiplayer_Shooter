using UnityEngine;

public class MonoGenericSingellton<T> : MonoBehaviour where T : MonoGenericSingellton<T>
{
    private static T _instance;
    public static T Instance => _instance;

    protected virtual void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = (T)this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
