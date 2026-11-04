# 3D Mobile Ball Collector Game - Unity 6

Bhai, is game ko setup karne ke liye ye steps follow karein:

### Step 1: Scene Setup
1. Unity open karein aur ek nayi 3D Core template project banayein.
2. **Ground:** Ek 'Plane' create karein (Right click -> 3D Object -> Plane). Iska Scale (5, 1, 5) rakhein.
3. **Player:** Ek 'Sphere' create karein. Ispe 'Rigidbody' component add karein. Iska naam "Player" rakhein.
4. **Pickups:** Kuch 'Cubes' banayein aur unhe ground par phailayein. Inka 'Is Trigger' checkbox (Box Collider mein) ON kar dein. Inhe "Pickup" tag dein.

### Step 2: UI Setup (For Mobile)
1. **Joystick:** Ek 'UI -> Image' banayein (Canvas automatically ban jayega). Iska naam "JoystickBG" rakhein. Iske andar ek chota circle banayein jiska naam "JoystickHandle" ho.
2. **Score Text:** Canvas mein ek 'UI -> Legacy -> Text' (ya TextMeshPro) add karein score dikhane ke liye.
3. **Win Panel:** Ek Panel banayein jo game khatam hone par "You Win!" dikhaye. Isse shuruat mein 'Deactivate' kar dein.

### Step 3: Scripts Attachment
1. `Assets/Scripts/` folder banayein aur niche diye gaye saare scripts wahan save karein.
2. **Player:** `PlayerController.cs` ko Player par attach karein.
3. **Main Camera:** `CameraController.cs` ko Camera par attach karein aur 'Player' object ko slot mein drag karein.
4. **Pickups:** `Rotator.cs` ko har Cube par attach karein.
5. **Canvas:** `GameManager.cs` aur `Joystick.cs` ko Canvas ya kisi Empty Object par attach karein.

### Step 4: Settings
1. **Build Settings:** File -> Build Settings mein jayein aur 'Android' ya 'iOS' select karke 'Switch Platform' karein.
2. **Input:** Game screen par joystick touch karke dekhein, ball move hogi!
