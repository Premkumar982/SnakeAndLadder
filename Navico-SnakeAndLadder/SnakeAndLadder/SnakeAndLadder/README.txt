How did i approach the problem ?

1. In Snake & Ladder game, token can go down or up so we need a placeholder for the values for moving up or down, 
which could be key value pair
2. Also a place holder for max score & max value for rolling of a dice
3. Random number generation for rolling a dice
4. Goal is to achieve the max score that was set until then 'players' needs to continue playing so started of 
with 'While'
5. Order of play doesn't change so used 'for' loop until the goal is reached
6. Check for value '1' to kick start the game until then players doesn't start the game
7. Once started, look up for the moving up or down place holder in step 1
8. Check the value has reached the max score, if it’s attained stop moving further and complete the game


How did you make key design decisions and what alternatives did you consider?

1. Should be tested using testing frameworks
2. Use factory to create instance so that tight coupling can be avoided which helps in TDD. 
3. Using Interfaces help in hiding the functionality so it future it can be plugged in 3rd party or other "play" methods


How do you envision your solution evolving in the future?

1. Platform is set of TDD which can be used for testing
2. Giving users to select a game from a list
3. Rolling 1 or 6 will fetch the player another chance to roll the dice
4. Asynchronous call to ‘play method’
