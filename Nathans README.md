A How to Guide on How to use our Dragon game in detail in under 1,3k words

Nathan Gates ST10440074

txtPlayer1Name

txtPlayer2Name

txtDragon1Name

txtDragon2Name

lblDragonStatsbtnSave1

btnSave1

btnSave2

btnStart

radFire1

radIce1

radWind1

radEarth1

radFire2

radIce2

radWind2

radEarth2

lblDragonStats

gbx1

gbx2

gbx3

Text Boxgbx4

txtDragon1Name

txtDragon2Name

lblDragon1Hp

lblDragon2Hp

gbx5

gbx6

gbx7

btnAtk

btnSAtk

btnBlock

btnRest

Form 1 acts as the initial ingress point for players when accessing the Dragon Battle Game. Here, the participants are greeted with an interface meticulously fashioned to serve as the preparatory phase for the impending clash of dragons. The display is bifurcated into two sections, encompassing:

Data Entry Boxes: The inclusion of four data entry boxes (txtPlayer1Name, txtDragon1Name, txtPlayer2Name, and txtDragon2Namec) provides players with a platform for personalization of both themselves and their dragon personas within the game. For instance, Player 1 may opt to designate themselves as 'Jack' and their draconic companion as 'Bob'.

Dragon Selection Radio Buttons: Positioned below the Data Entry Boxes are a total of eight radio buttons, four for each player, offering a diverse array of choices for the impending confrontation. Each dragon boasts its own unique statistics, elucidated in the label on the right-hand side, furnishing a comprehensive breakdown of each dragon and their attributes. This affords players a more strategic approach to the game.

Dragon Statistics Display (Label): Supplementing the overall User Interface (UI) is a label situated on the right-hand side of the screen. Herein lies a compilation of each dragon option and their attributes, aiding players in making informed decisions for the forthcoming battle.

Save Button: Located beneath the Radio Buttons are two buttons, one for each player. These serve as the save mechanism, storing the player's name, dragon name, and dragon choice for both Player 1 and Player 2. The inclusion of two distinct save buttons ensures separate data storage for each player.

Form 2 serves as the epicenter for the ensuing 'battle' sequences within the game. Upon activating the Start Button on Form 1, players seamlessly transition to Form 2, where they are presented with an array of options dictating the course of the battle.

Decision Buttons: Form 2 hosts a quartet of buttons—btnAtk, btnSstk, btnBlock, and btnRest—each offering a distinct course of action.

btnAtk: Initiates an attack, resulting in damage inflicted and a decrease in Health points for the players. btnSAtk: Activates the Special Attack feature, inflicting a substantial amount of damage and triggering the appearance of btnRest in the subsequent turn for the initiating player. btnRest: Materializes after a player chooses to execute their special attack, allowing the player's dragon to recuperate. btnBlock: Engages a defensive stance, diminishing the damage inflicted upon a player's dragon.

Battle Log: Situated at the bottom of Form 2 is a rich text box dubbed the battle log, meticulously chronicling the sequence of events and their outcomes in chronological order. Its scrollable nature enables players to review all actions taken, fostering a more strategic approach to the game.

Turn and Health Indicators: To enhance clarity between players, Form 2 integrates labels indicating which player and dragon holds the turn. Additionally, these labels exhibit the health points of corresponding dragons, enabling players to gauge the efficacy of their approach to the battle.

Player Inputs: On Form 1, players encounter four data entry boxes, two allocated to each player. These facilitate the input of player and dragon names, enabling players to distinguish whose turn it is and allowing for personal customization.

Dragon Choice: Form 1 offers a total of eight radio buttons, four for each player. Each player possesses four radio buttons, each presenting four distinct choices of dragons. This affords players the flexibility to adopt different approaches to the impending battle.

Combat Options: Form 2 prompts players to select their actions for each turn, encompassing Attack, Block, Special Attack, and Rest. These diverse actions dictate the outcomes of each turn and ultimately determine the game's outcome.

Output: Form 2 serves as the arena where battles unfold, with each player's input being output in the battle log on Form 2. The battle log encapsulates:

Damage Dealt and Blocked: Detailing all inflicted and blocked damage, offering insights into the ebb and flow of the confrontation. Player Decisions: Narrating every move undertaken by players, enriching the immersive experience. Health Points (HP) Updates: Reflecting the dynamic changes in HP as the battle ensues, ensuring players stay abreast of their dragon's vitality. Turn Indicators: Utilizing player names from Form 1, these indicators elucidate turn ownership and dragon health, minimizing confusion and enhancing engagement.

The rationale behind these outputs lies in amplifying user engagement and immersion. The battle log serves as a feedback mechanism, providing nuanced insights into strategic efficacy. Concurrently, updates to health point labels and player names foster clarity, cultivating an enjoyable gaming experience for users.

The logic underpinning the Dragon Fighter Game commences with Form 1. Here, two players encounter two Data Entry Boxes labeled player name and dragon name. Players are prompted to enter their names and their dragon's name. Subsequently, users select a dragon using the four radio buttons, guided by the label on the side displaying each dragon's health points, attack, block damage, and special attack. These dragons and their diverse stats encompass:

Fire Dragon: 20 HP, 5 Attack Damage, 12 Special Attack Damage, 4 Block Damage. Ice Dragon: 30 HP, 4 Attack Damage, 9 Special Attack Damage, 5 Block Damage. Wind Dragon: 40 HP, 3 Attack Damage, 7 Special Attack Damage, 5 Block Damage. Earth Dragon: 50 HP, 2 Attack Damage, 5 Special Attack Damage, 6 Block Damage.

All user inputs are stored in an array after pressing the SAVE button. With two save buttons, data is saved for Player 1 if the corresponding save button is pressed and for Player 2 if the respective save button is pressed. Once both players are ready, they can press the button labeled "Start Game" to initiate the transition between Form 1 and Form 2.

In Form 2, multiple labels and buttons facilitate player decision-making. Initially, a basic attack ensues between players. If both players choose to attack, both players' dragons will lose health points. For instance, "Bob attacked, inflicting 9 damage to Frank," and "Frank attacked, inflicting 7 damage to Bob." These actions are outputted to the rich text box at the bottom, allowing users to review. Updates to health point labels are made accordingly.

In another scenario, if one player attacks and the other blocks, the rich text box updates accordingly. For example, "Bob attacked, inflicting 5 damage to Frank, but Frank blocked for 5, resulting in zero damage." The block system utilizes a boolean system; if Frank blocks, the boolean is true, reducing the damage inflicted. In instances where both players block, the rich text box is updated to reflect that no damage is taken.

If the special attack button is pressed, another button labeled rest will appear in the player's next turn. This allows the dragon to "rest" after executing the special attack. For instance, if Player 1 presses the special attack button, dealing 12 damage, the battle log will display "Bob used their special attack, dealing 12 damage to Frank," and in the subsequent turn, the player is compelled to "rest."

Should Frank decide to block, using the Wind Dragon, the overall damage would be calculated, and the battle log would reflect this outcome. Conversely, if Frank attacks, the battle log will document the damage inflicted. Subsequently, Bob is forced to press the Rest button, abstaining from inflicting or blocking damage in the next turn.

The game progresses until either player's HP reaches zero or falls below zero. The battle log updates accordingly, declaring the victor based on which dragon reaches zero health first.
