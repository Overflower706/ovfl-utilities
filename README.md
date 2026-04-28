# OVFL Utilities

Unity 범용 유틸리티 패키지입니다. 싱글톤 패턴 3종과 에디터 전용 디버그 도구를 제공합니다.

## 제공 클래스

### Singleton\<T\> — 순수 C# 싱글톤
MonoBehaviour가 불필요한 매니저 클래스에 사용합니다.
```csharp
public class GameManager : Singleton<GameManager>
{
    private GameManager() { } // private 생성자 필수

    public void StartGame() { ... }
}

GameManager.Instance.StartGame();
```

### SceneSingleton\<T\> — 씬 배치형 MonoBehaviour 싱글톤
씬에 미리 배치된 GameObject에 사용합니다. 중복 인스턴스는 자동 제거됩니다.
```csharp
public class UIManager : SceneSingleton<UIManager>
{
    public void ShowPanel() { ... }
}

UIManager.Instance.ShowPanel(); // 씬에 없으면 null
```

### LazySceneSingleton\<T\> — 자동 생성 MonoBehaviour 싱글톤
`Instance` 접근 시 씬에 없으면 GameObject를 자동으로 생성합니다.
```csharp
public class SoundManager : LazySceneSingleton<SoundManager>
{
    public void Play(AudioClip clip) { ... }
}

SoundManager.Instance.Play(clip); // 항상 안전하게 접근 가능
```

### DebugEx — 에디터 전용 로그
`[Conditional("UNITY_EDITOR")]`로 선언되어 빌드에서는 호출 자체가 제거됩니다.
```csharp
DebugEx.Log("에디터에서만 출력됩니다.");
DebugEx.LogWarning("빌드 성능에 영향 없음.");
```

## 설치 방법

### Package Manager (git URL)
1. **Window > Package Manager** 열기
2. 좌상단 **+** → **Add package from git URL...**
3. 아래 URL 입력:
   ```
   https://github.com/Overflower706/utilities.git
   ```

### manifest.json 직접 편집
```json
{
  "dependencies": {
    "com.ovfl.utilities": "https://github.com/Overflower706/utilities.git"
  }
}
```

## 요구사항

- Unity 6000.1 이상
- com.unity.inputsystem 1.18.0 이상
- com.unity.ugui 2.0.0 이상
