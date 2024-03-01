# DotnetConf2024-MusicPlayerSample
[.NET Conf 2024 x Seoul](https://dotnetconf.kr/2024) "신입 iOS개발자가 해 본 첫 .NET 모바일 앱 개발" 세션의 예제 앱 코드입니다

## 소개
- Uno Platform을 사용해 만든 iOS, Android 크로스 플랫폼 앱입니다
- 음악을 재생/일시정지 할 수 있습니다 
- Xaml을 사용해 UI를 구현합니다
- MVVM 기반이며, `CommunityToolkit.Mvvm.ComponentModel`도움을 받아 `ViewModel`을 작성합니다
- 음악 재생은 iOS는 `AVAudioPlayer`, Android는 `MediaPlayer`를 사용합니다.
- 플랫폼 통합을 하기위해 `IMusicPlayer` 인터페이스를 정의하고, 각 플랫폼별로 구체 타입을 구현합니다.
- `ViewModel`과 `MusicPlayer`는 `ServiceContainer`로부터 주입받습니다.

<br>

💁🏻‍♀️코드에 대한 상세한 설명은 발표 PDF를 참고해주세요
