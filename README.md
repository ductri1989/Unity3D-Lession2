# Nhân vật chuyển động
Làm quen với nhân vật 3D trên https://www.mixamo.com

### Phạm vi bài giảng
- Đăng ký tài khoảng trên Mixamo
- Setup nhân vật
    - Tải nhân vật Maria
    - Giải nén Textures và Materials
    - Tải animation : idle,move,attack,jump
    - Tạo AnimatorController → Setup Blendtree cho hành động idle và moving
    - Xử lý phím di chuyển nhân vật
- Xoay nhân vật và GameObject
  - `Rotate` : 4 trường hợp
  - `RotateAround` : 4 trường hợp
  - `eulerAngles` : 4 trường hợp
  - `Quaternion`


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
    + 📁Các plugin trong game
    + 📁Scenes
        + 📁Model
            + 📁Maria : tất cả resource của nhân vật `Maria` sẽ nằm trong folder này (những anim riêng cũng nằm trong folder này)
            + 📁Animation : nơi chứa các animation chung của tất cả nhân vật
        + 📁SC_Splash : nơi chứa tài nguyên của Scene 
        + 📁SC_Home : Sau khi vào splash thì vào home
        + 📁SC_LV1 : Sau khi vào splash thì vào home
            + 📄Scene_LV1 : tên scene có tiền tố `Scene_` để dễ search trên `Unity Editor`
            + ⚙️GameManager.cs : script quản lý chung của scene (có biểu tượng ⚙️)
+ Document
    * tài liệu chung
    * SC_Splash
    * SC_Home

