# Rock Paper Scissors

#### _C#, .NET: Rock Paper Scissors, 12/18/2019_

## Description
Create a Rock, Paper, Scissors console application. User inputs "Rock", "Paper" or "Scissors" then computer returns its hand.
Console shows who wins.

## Application should have:
- Interact with user and take the input
- Computer returns its hand after user inputs their hand.
- Console shows the winner of the game.
- Game will continue till user types "no".
- Unit test for backend logic.

### Combination of the Rock Paper Scissors

|  |  | | |
| :-- | :-- | :-- | :-- |
| Rock | vs | Scissors | __Rock__ wins |
| Rock | vs | Paper | __Paper__ wins |
| Paper | vs | Scissors | __Scissors__ wins |
| Rock | vs | Rock| __Draw__ (same hands)|

## Unit Testing
| Spec | User input | Expected output |
| :------------- | :------------- | :------------- |
| User inputs "Rock" and user wins | Rock | Computer hand: Scissors, Result of game: Player |
| User inputs "Rock" and computer wins | Rock | Computer hand: Paper, Result of game: Computer |
| User inputs "Rock" and result becomes draw | Rock | Computer hand: Rock, Result of game: Draw |
| User inputs besides "Rock", "Paper" or "Scissors | Hello | Invalid input |
| User inputs besides "Rock", "Paper" or "Scissors | 12345 | Invalid input |
| User continue the game | yes | Enter "Rock/Paper/Scissors": |
| User doesn't continue the game | no | Thank you for playing with us! |
| User input besides yes or no to the "Do you want to play again?" question | Hello world | Invalid input |
 

## Setup/Installation Requirements

1. Clone this repo:
```
$ git clone hhttps://github.com/misakimichy/RockPaperScissors.Solution.git
```

2. Go into the repo and run this application:
```
$ dotnet run
```

## Known Bugs
* No known bugs at this time.

## Support and contact details
 misaki.koonce@gmail.com

## Technologies Used
_Git, GitHub, C# and MS Test


## License
Copyright © 2019 under the MIT License