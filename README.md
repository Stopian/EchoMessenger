# (C# 코딩) 에코 메신저
## 개요
- C# 프로그래밍 학습
- 1줄 소개: 사용자의 키보드 입력을 화면에 적절히 표시하는 프로그램
  
- 사용한 플랫폼:
  > C#, .NET Windows Forms, Visual Studio, GitHub
- 사용한 컨트롤:
  > Label, TextBox, ListBox, Button
- 화면 구성:
  > 중앙의 lstTextInput, lstTextInput 아래의 txtUserInput, txtUserInput 옆의 전송 버튼, 화면 상단의 lblProgramName
- 사용한 기술과 구현한 기능:
  > Visual Studio를 이용하여 UI 디자인
  
  > string 클래스를 이용한 사용자 입력 데이터 처리

  ## 실행 화면 (과제1)
- 과제1 코드의 실행 스크린샷
![과제1스크린샷]<img width="1095" height="657" alt="image" src="https://github.com/user-attachments/assets/e64a652e-9be4-4c16-b21e-ca936d5904bc" />

 - 과제 내용
   > 중앙의 lstTextInput (대화창), lstTextInput 아래의 txtUserInput (입력), txtUserInput 옆의 전송 버튼 (전송), 화면 상단의 lblProgramName (표시) 를 적절히 배치
   
   > 전송 버튼 클릭 시 txtUserInput의 텍스트를 lstTextInput의 항목(Items)으로 추가합니다.
   
   > 추가 직후 txtUserInput의 내용을 비워("") 다음 입력을 준비합니다.
- 구현 내용과 기능 설명
  > 입력창에 메시지를 입력하고 전송 버튼을 누르면 메시지가 리스트 박스에 표시된다.
  
  > 계속 반복하면 메시지가 리스트 박스에 한 줄씩 계속 추가된다.

    ## 실행 화면 (과제2)
  - 과제2 코드의 실행 스크린샷
![과제2스크린샷] (img/echo2.png)
![과제2GIF] (img/echo2.gif)
- 과제 내용
   > 입력창에 입력 포커스 갖다 놓기
   
   > 엔터키로 전송하기
   
   > 공백 입력시 입력 방어

- 구현 내용과 기능 설명
  > 입력창에 메시지를 입력하고 전송 버튼을 누른 뒤 자동으로 입력창에 포커스가 된다.
  
  > 엔터키로도 메시지를 전송할 수 있으며 공백을 입력 시 재호출 되도록 구성하였다.