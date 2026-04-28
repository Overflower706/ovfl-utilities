public class Singleton<T> where T : Singleton<T>
{
    private static T _instance;

    public static T Instance
        => _instance ??= (T)System.Activator.CreateInstance(typeof(T), nonPublic: true);

    // 상속받은 클래스에서 private 생성자를 추가하세요.
    // 예: private MyManager() { }
    protected Singleton() { }
}
