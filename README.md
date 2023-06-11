# OOPfinal




mainForm.cs
>메인화면
![ArrStack](https://github.com/KS2019775054/OOPfinalimage/blob/main/1.JPG?raw=true)
메인화면이며 실행시 나오는 첫 화면이다
화면경로 : 메인화면/
>1. 매장주문 버튼 - 클릭시 메뉴화면 이동 
>2. 포장주문 버튼 - 클릭시 메뉴화면 이동

MenuForm.cs
> 메뉴화면
![ArrStack](https://github.com/KS2019775054/OOPfinalimage/blob/main/2.JPG?raw=true)
메뉴 화면이며 커피 메뉴가 이미지로 표시되어 있다.
화면 경로 : 메인화면/메뉴화면
>1. 메뉴이미지 버튼 - 클릭시 옵션화면 이동
>2. 주문 목록 ( 텍스트 표현 / 스크롤 가능 ) 
>3. 전체 가격 표시 
>4. 결제하기 버튼 - 클릭시 주문확인 화면 이동


DetailMenuForm.cs
>상세메뉴화면
![ArrStack](https://github.com/KS2019775054/OOPfinalimage/blob/main/3.JPG?raw=true)
상세메뉴화면이며 다양한 옵션을 추가,삭제 할 수 있다.
화면경로 : 메인화면/메뉴화면(메뉴버튼)/상세메뉴화면/
>1. 메뉴 이미지
>2. 메뉴 명
>3. 수량 + - 버튼으로 조절 가능
>4. 사이즈 버튼 - 클릭시 선택된 버튼 색 변경
>5. 샷추가 수량 + - 버튼으로 조절 가능
>6. 설탕 시럽 수량 + - 버튼으로 조절 가능
>7. 헤이즐 시럽 수량 + - 버튼으로 조절 가능
>8. 카라멜 시럽 수량 + - 버튼으로 조절 가능
>9. 메뉴 가격 표시
>10. 취소 버튼 - 클릭시 메뉴화면으로 이동
>11. 주문 버튼 - 클릭시 메뉴화면으로 이동 주문목록에 메뉴 추가

OrderConfirmForm.cs
>주문확인화면
![ArrStack](https://github.com/KS2019775054/OOPfinalimage/blob/main/5.JPG?raw=true)
주문확인 화면이며 전체 메뉴와 부가옵션과 가격이표시되어있음
화면경로 : 메인화면/메뉴화면(결제)/주문확인화면
>1. 주문확인 카테고리
>2. 전체 주문 목록 ( 텍스트 표현 / 스크롤 가능 )
>3. 주문금액,할인금액,결제금액 표시
>4. 전체취소 버튼 - 클릭시  메뉴화면 이동후 주문목록 삭제
>5. 이전 버튼 - 클릭시 메뉴화면으로 이동
>6. 다음 버튼 - 클릭시 결제방식 화면으로 이동


PaymentMethodForm.cs
>결제방식화면
![ArrStack](https://github.com/KS2019775054/OOPfinalimage/blob/main/6.JPG?raw=true)
결제방식 화면이며 결제방식을 고를 수 있다
화면경로 : 메인화면/메뉴화면(결제)/주문확인화면/결제방식화면
>1. 결제하기 카테고리
>2. 삼성페이 버튼 - 클릭시 색 변경
>3. 애플페이 버튼 - 클릭시 색 변경
>4. 카카오 페이 버튼 - 클릭시 색 변경
>5. 페이코 버튼 - 클릭시 색 변경
>6. 주문금액,할인금액,결제금액 표시
>7. 전체취소 버튼 - 클릭시  메뉴화면 이동후 주문목록 삭제
>8. 이전 버튼 - 클릭시 주문확인화면 이동
>9. 다음 버튼 - 클릭시 결제하기화면 이동

PayForm.cs
>결제하기화면
![ArrStack](https://github.com/KS2019775054/OOPfinalimage/blob/main/7.JPG?raw=true)
결제하기 화면이며 결제를한다
화면경로 : 메인화면/메뉴화면(결제)/주문확인화면/결제방식화면/결제하기화면
>1. 결제하기 카테고리
>2. 결제 설명판
>3. 주문금액,할인금액,결제금액 표시
>4. 전체취소 버튼 - 클릭 이벤트 없음
>5. 이전 버튼 - 결제방식화면이동
>6. 다음 버튼 - 결제완료화면이동


PaymentCompleteForm.cs
>결제완료화면
![ArrStack](https://github.com/KS2019775054/OOPfinalimage/blob/main/8.JPG?raw=true)
결제완료 화면이며 감사문구와 대기번호가 출력된다.
화면경로 : 메인화면/메뉴화면(결제)/주문확인화면/결제방식화면/결제하기화면/결제완료화면
>결제완료 안내 문구와 대기번호와 감사문구가 출력된다.
결제완료 버튼 클릭시 SMS 를 보낸다.



OrderHistory.cs
>주문내역 화면
![ArrStack](https://github.com/KS2019775054/OOPfinalimage/blob/main/9.JPG?raw=true)
주문내역화면이며 전체 주문내역이 보인다
화면경로 : 메인화면/주문내역

문자
>문자화면
![ArrStack](https://github.com/KS2019775054/OOPfinalimage/blob/main/10.JPG?raw=true)
twilio 기능을 이용하여 문자를 보낸다.
