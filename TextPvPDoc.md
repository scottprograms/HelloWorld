| Scott Peters|
| :---              |
| s208070     |
| Text Based Adventure Game Documentation |

### I. Requirements

##### 1. Description of Problem

- **Name**: Text Based Adventure Project

- **Problem Statement**: Creation of a game using Visual Studios approved by the teacher, and must implicate multiple techniques that was taught.

- **Problem Specifications**: A text based game where the user makes decisions to control a character that was selected. The user also controls the stroyline of character selected. For example the user's character has the option to engage in a battle if chosen.

##### 2. Input Information

- The #1 on the keyboard - will select the first option provided
- The #2 on the keyboard - will select the second option provided
- The #3 on the keyboard - will select the third option provided
- The #4 on the keyboard - will select the fourth option provided

1. Output Information
 
-The storyline can be adjusted on the decisions that the user selects.

### II. Design

**Text Based Adventure**

<img src="Images/TextGameImage">


#### Object Information

**File** : Dragon.cs

Name: fire
Description: An attack that the dragon can preform
Type: int

Name: claw
Description: An attack that the dragon can preform
Type: int

Name: scales
Description: A form of defense that is attached to health
Type: int

Name: hearing
Description: A form of defense that is attached to magic
Type: int

**File** : enemy.cs

Name: health
Description: A way of counting the users durability of damage
Type: int

Name: damage
Desciption: The amount of health a player can lose
Type: int

Name: name
Desciption: Is what the user wants to be referred as
Type: string

Name: magic
Description: A way of inflicting damage on an enemy or a way of defending
Type: int

**File** : Game.cs
Name: name
Decription: Is what the user wants to be referred as
Type: string

Name: health
Description: A way to store the users health
Type: float

Name: healthRegen
Description: The process of healing
Type: float

Name: level
Description: A way of keeping track of the user's progress
Type: int

Name: ready
Description: The beginning of the game
Type: bool

Name: role
Description: The option to choose from more that one character
Type: string

Name: enemy
Description: A group of ints that make up a character that the user must face
Type: Array

Name: dragon
Description: The ending battle of the game
Type:Array








