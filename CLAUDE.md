# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## 작업 범위

**이 폴더(`com.ovfl.utilities/`) 내부로 작업 범위를 국한한다.**
- 다른 프로젝트(`Catverse`, `Elis_In_Winterland`, `com.ovfl.ecs`)의 파일은 읽거나 수정하지 않는다.
- 폴더 간 작업(여러 프로젝트에 걸친 변경)은 상위 `Chapter3/CLAUDE.md`에서만 수행한다.

## 언어

모든 답변은 한국어로 작성한다.

## 패키지 개요

`com.ovfl.utilities`는 Unity 범용 유틸리티 패키지로, `Catverse`와 `Elis_In_Winterland` 두 게임 프로젝트에서 공유하는 싱글톤 패턴과 디버그 도구를 제공합니다.

- Unity 최소 버전: **6000.1**
- Assembly: `OVFL.Utilities.Runtime` (`autoReferenced: true` — 별도 참조 선언 없이 사용 가능)
- 의존: `Unity.InputSystem`, `Unity.ugui`

## 싱글톤 세 가지 구분

| 클래스 | 용도 |
|---|---|
| `Singleton<T>` | 순수 C# 싱글톤. MonoBehaviour 불필요한 매니저류에 사용. 생성자는 `protected`이므로 서브클래스에서 `private` 생성자 추가 필요. |
| `SceneSingleton<T>` | 씬에 미리 배치된 MonoBehaviour 싱글톤. 중복 인스턴스는 `Destroy(gameObject)`. |
| `LazySceneSingleton<T>` | MonoBehaviour 싱글톤. `Instance` 접근 시 씬에 없으면 GameObject를 자동 생성. |

`SceneSingleton`은 Instance가 null일 수 있으므로 씬 전환 시 주의. `LazySceneSingleton`은 씬에 없어도 안전하게 접근 가능.

## DebugEx

`[Conditional("UNITY_EDITOR")]`로 선언되어 **에디터 전용**으로만 동작합니다. 빌드에는 호출 자체가 제거됩니다. `UnityEngine.Debug` 대신 `DebugEx`를 사용하면 빌드 성능에 영향 없이 로그를 남길 수 있습니다.

## UIDebugger

Canvas에 달린 `GraphicRaycaster`가 필요합니다. 마우스 좌클릭 시 최상위 UI 요소를 `DebugEx.Log`로 출력합니다. 개발/디버깅 전용 컴포넌트이므로 프로덕션 빌드에는 포함하지 않습니다.

## 테스트

기능 구현시 적절한 테스트도 함께 구현한다.

## 작업 범위

이 패키지 파일만 관리한다. 파일 추가·수정·삭제 시 다른 프로젝트(`Catverse`, `Elis_In_Winterland`)의 사용 현황을 조사하거나 확인하지 않는다.