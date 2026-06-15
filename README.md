# \# Number Wizard

# 

# \## Description

# 

# Number Wizard is a simple Unity game in which the computer tries to guess a number that the player has in mind.

# 

# The game uses the binary search algorithm to reduce the search range after each answer and find the correct number efficiently.

# 

# \---

# 

# \## How to Play

# 

# 1\. Think of a number within the given range.

# 2\. The game displays a guess.

# 3\. Use the buttons to tell the game whether the guess is correct.

# 

# \### Buttons

# 

# \*\*Higher\*\*

# 

# \* Click if your number is higher than the current guess.

# \* The lower boundary is increased and a new guess is calculated.

# 

# \*\*Lower\*\*

# 

# \* Click if your number is lower than the current guess.

# \* The upper boundary is decreased and a new guess is calculated.

# 

# \*\*Correct\*\*

# 

# \* Click if the displayed guess matches your number.

# \* A success message is shown and the game ends.

# 

# \*\*Restart\*\*

# 

# \* Starts a new game.

# \* Resets the number range and calculates a new first guess.

# 

# \---

# 

# \## Binary Search

# 

# The game uses a binary search strategy.

# 

# After each answer, half of the remaining search range is discarded. The next guess is always calculated as the middle value of the current range.

# 

# This allows the game to find the correct number in only a few steps.

# 

# \---

# 

# \## Unity Version

# 

# Unity Version: 6000.0.57f1

# 

# 

# \---

# 

# \## Start Scene

# 

# Start Scene: MainScene

# 

