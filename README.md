# NumberGuesser

--input-work-output
--int-function-string
--DRY
--pedaco
Problem
Example
Data set
Algorithm
Code
Organize

---

Problem
Explorer
-The code will try to guess the user number (store in their head) between 1-1024
-If the code is wrong on the first try, the code will try to guess further numbers sequentially or non-sequentially
-code cannot prompt user for the number guess
-code can prompt for direction like high or lower or correct
-must use methods
ShowGreeting
ComputeNewLowIfTooLow
ComputeNewHighIfTooHigh
BragWhenCorrect

Adventure
-User need to be able to guess maximum range (1024)
-Tell them the max number of guesses the code will need to guess
-prompt the user to play again at the end of the game (i might be able to use old code from variable assignment)

Epic
-Keep track of how many guesses each game has taken and show the average number of guesses your code has used

Example
Greetings. I am the amazing Number Guesser.

                  Please think of, BUT DO NOT TELL ME, a number between 1 and 1024.

                  Using my amazing computing power I will figure out your number by asking you questions.

                  Here we go!

                  My guess is 1. Is your number HIGHER, LOWER, or am I CORRECT? HIGHER

                  Ok, higher.

                  My guess is 2. Is your number HIGHER, LOWER, or am I CORRECT? HIGHER

                  Ok, higher.

                  My guess is 3. Is your number HIGHER, LOWER, or am I CORRECT? CORRECT

Data set - Methods, loops, if then, nested loops

Algorithm for adventure mode

//1. greet user (METHOD A)
//2. Prompt user to guess a number between 1 and 1024
//3. Ask user "Do you have a number in your mind, enter yes or no"
//4. If input is yes then display a RANDOMLY guessed number
//5. Ask user "Is my guess CORRECT, or is your number HIGHER or LOWER" (loop?) (i don't know how to //do the math/code here)
//6. If HIGHER then guess a HIGHER number in the middle of the list of numberS then return to step 5
// (loop?) (i don't know how to do the math/code here) (METHOD C)
//7. IF LOWER then guess a LOWER number in the middle of the list of number then return to step 5
//(loop?) (i don't know how to do the math/code here) (METHOD B)
//8. Repeat (loop) steps 5 (6 or 7) until user inputs CORRECT (loop)
//9. When user input is CORRECT display "that was easy" (METHOD D)
//10. step 3: else display "Come on I don't have all day!" then return to step 3 until answer is yes //(loop?)

    Need methods
    A. ShowGreeting
    B. ComputeNewLowIfTooLow
    C. ComputeNewHighIfTooHigh
    D. BragWhenCorrect
