EXTERNAL ShowCharacter(characterName, position, mood) 
EXTERNAL HideCharacter(characterName)
EXTERNAL ChangeMood(characterName, mood)
EXTERNAL ShowBackground(backgroundName,sprite,position)
EXTERNAL HideBackground(backgroundName)
EXTERNAL ChangeBackground(backgroundName,sprite)

-> start

=== start ===
//{ShowBackground("Bg", "Workingroom", "center")}
{ShowCharacter("Detective", "Left", "Serious")}
「まいったな・・・」
町に事務所を構えている探偵オリヴァーは、      警察からある依頼を受けていた。
その依頼は、今巷で噂になっている連続殺人事件
オリヴァーは、犯人の目星は殆ど付いており   
あとは確実な証拠
凶器を見つけるだけ、たが・・・
「ほんとにあいつなのか・・・」
目星を付けた相手それは、学生時代の旧友
今は、町はずれの個人病院を経営しているジャックだった。
そして今、自分の推理を確かめるため病院のドアをノックした。
{HideCharacter("Detective")}
{ShowBackground("Bg", "House", "center")}
{ShowCharacter("Killer", "Left", "Serious")}
「遅かったじゃないか、まあ入れよ」
そういった旧友ジャックの瞳は
何か情熱の炎が燃え滾っている用に思えた。
->END
