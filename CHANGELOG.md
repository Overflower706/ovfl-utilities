# Changelog

All notable changes to this project will be documented in this file.

## [1.0.1] - 2026-04-28

### Changed
- OVFL.ECS 테스트 프로젝트에 로컬 패키지로 연결

## [1.0.0] - 2026-04-28

### Added
- 초기 릴리즈
- `Singleton<T>` — 순수 C# 싱글톤
- `SceneSingleton<T>` — 씬 배치형 MonoBehaviour 싱글톤
- `LazySceneSingleton<T>` — Instance 접근 시 자동 생성 MonoBehaviour 싱글톤
- `DebugEx` — 에디터 전용 조건부 로그 (`[Conditional("UNITY_EDITOR")]`)
