# Bài 3 : Camera đi theo nhân vật chuyển động
Chủ đề : game nhập vai. Điều khiển 1 nhân vật đánh quái, mở rương và nhặt item. Giết quái và đánh nhiều boss ở các ma, nNhân vật sẽ thu thập được nhiều Gold và vật phẩm

### Phạm vi bài giảng
- Tạo project 3D
- Tải nhân vật Maria và các hành động : idle,move,attack,jump
- Setup nhân vật
- Setup camera
- Setup animation
- Trang trí map

### Resource

| Mixamo | https://www.mixamo.com |
| ------ | ------ |
| Nhân vật | Maria W/Prop J J Ong |
| Idle | Unarmed Idle |
| Move | Unarmed Run Forward |
| Attack | Standing Melee Attack Horizontal |
| Jump | jumping |

### Cấu trúc Folder
+ Assets
    + Các plugin trong game
    + Scenes
        + Model
            + Maria : tất cả resource của nhân vật `Maria` sẽ nằm trong folder này (những anim riêng cũng nằm trong folder này)
            + Animation : nơi chứa các animation chung của tất cả nhân vật
        + SC_Splash : nơi chứa tài nguyên của Scene 
        + SC_Home : Sau khi vào splash thì vào home
        + SC_LV1 : Sau khi vào splash thì vào home
            + Scene_LV1 : tên scene có tiền tố `Scene_` để dễ search trên `Unity Editor`
            + GameManager.cs : script quản lý chung của scene (có biểu tượng ⚙️)
+ Document
    * tài liệu chung
    * SC_Splash
    * SC_Home
