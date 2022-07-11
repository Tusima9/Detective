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
オリヴァー:「見つけたっ！　これが証拠だ」
{ShowCharacter("Killer", "Right", "Serious")}
ジャック:「オリヴァー……」
「あの頃のお前は、もういない」
{ChangeMood("Detective", "Surprised")}
オリヴァー:「そ、それはどういう」
{ChangeMood("Killer", "Surprised")}
ジャック:「君の目も、どうやら節穴だったようだ」
***「え……」
{ChangeMood("Killer", "Upset")}
ジャック:「早くそれをもって私の前から消えてくれ」
「もう二度と、お前たちと会うことはないだろう……」
{HideCharacter("Killer")}
{HideCharacter("Detective")}
{ChangeBackground("Bg", "Bedroom2")}

//hide background to black
それからオリヴァーは警察に証拠品を持っていったところ#thought
事件との関連性はなかった。#thought
再び現場へと戻るも#thought
そこには何も残されておらず#thought
ジャックも姿を消していた。#thought
それ以降も行方を追ったが宛は無く#thought
連続殺人事件は常しえの闇へと飲み込まれていった。#thought
{ChangeBackground("Bg", "Fourroom")}
//menuBack container
->END