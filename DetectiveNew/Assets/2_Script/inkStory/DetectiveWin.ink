EXTERNAL ShowCharacter(characterName, position, mood) 
EXTERNAL HideCharacter(characterName)
EXTERNAL ChangeMood(characterName, mood)
EXTERNAL ShowBackground(backgroundName,sprite,position)
EXTERNAL HideBackground(backgroundName)
EXTERNAL ChangeBackground(backgroundName,sprite)

-> start

=== start ===
{ShowBackground("Bg","Livingroom", "center")}
//{ShowBackground("Bg", "Workingroom", "center")}
{ShowCharacter("Detective", "Left", "Upset")}
「これだ！！これが凶器だろう？」
{HideCharacter("Detective")}
{ShowCharacter("Killer", "Left", "SadHappy")}
「フッ・・・その通りだ」
「結局お前には、いつまでも勝てないみたいだ」
{HideCharacter("Killer")}
{ShowCharacter("Detective", "Left", "Crying")}
「何を言って」
{HideCharacter("Detective")}
{ShowCharacter("Killer", "Left", "Upset")}
そう言いかけた時、ジャックはオリヴァーが持っていた凶器を手にし
自害した。　　　　　　　　　　　　　
{HideBackground("Bg")} // redoo bug 
//song + blood
{HideCharacter("Killer")}
//without fade out 
{ShowCharacter("Detective", "Left", "Surprised")}
あまりに一瞬の出来事に理解が出来ずオリヴァーは少し考えたが 
理解できなかった、自害した事、いつまでも勝てないという事
{ChangeMood("Detective", "Sad")}
その意味が・・・
そうして連続殺人事件は幕を閉じた。
->END
