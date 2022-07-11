EXTERNAL ShowCharacter(characterName, position, mood) 
EXTERNAL HideCharacter(characterName)
EXTERNAL ChangeMood(characterName, mood)
EXTERNAL ShowBackground(backgroundName,sprite,position)
EXTERNAL HideBackground(backgroundName)
EXTERNAL ChangeBackground(backgroundName,sprite)
-> start_knot // this tell ink where to start the story

=== start_knot ===
{ShowBackground("Bg", "House", "center")}
{ShowCharacter("Detective", "Left", "Upset")}
オリヴァー:「証拠は見つけた。これでお前の悪事は暴かれる」
{ShowCharacter("Killer", "Right", "Serious")}
ジャック:「……」
{ChangeMood("Detective", "Sad")}
オリヴァー:「なぁ、ジャックは何がしたかったんだ？」
{ChangeMood("Killer", "SadHappy")}
ジャック:「フッ……、それは教えられないな」
「私とお前とでは住む世界が違う」
「さらばだ、探偵。またどこかで会えるといいな」
オリヴァー:ジャックの身柄は警察に引き取られ、その後の詳細は聞かされなかった。#thought
これで連続殺人事件は解決した。#thought
しかし、ジャックは本当に、何をしたかったのだろうか……#thought
{HideCharacter("Killer")}
{ChangeMood("Detective", "SadHappy")}
{ChangeBackground("Bg", "Fourroom")}
->END