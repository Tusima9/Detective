EXTERNAL ShowCharacter(characterName, position, mood) 
EXTERNAL HideCharacter(characterName)
EXTERNAL ChangeMood(characterName, mood)
EXTERNAL ShowBackground(backgroundName,sprite,position)
EXTERNAL HideBackground(backgroundName)
EXTERNAL ChangeBackground(backgroundName,sprite)

-> start

=== start ===
{ShowBackground("Bg", "House", "center")}
{ShowCharacter("Detective", "Left", "Upset")}
「これが凶器だろう？」
{HideCharacter("Detective")}
{ShowCharacter("Killer", "Left", "SadHappy")}
「フッハハハハハ」
{HideCharacter("Killer")}
{ShowCharacter("Detective", "Left", "Upset")}
「なにがおかしい？」
{HideCharacter("Detective")}
{ShowCharacter("Killer", "Left", "Fine")}
「いや、いいそれを証拠として警察にもって行くといい」
{ChangeMood("Killer", "Upset")}
「君には失望したよそれを持って早く帰りたまえ」
{HideCharacter("Killer")}
{ShowCharacter("Detective", "Left", "Serious")}
{HideBackground("Bg")}
後日警察に見せた凶器は、どの殺人の凶器にも一致せず
オリヴァーは、解決しない連続殺人事件を追って
心の内に黒い何かを抱えながらその生涯を終えた。
->END