# Week 5: Guess the Number - Study Notes

**Name:** Katherine Ayala

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
Answer:a do while look runs at least once before checking the true/false condition, while a loop checks the true/false condition first and may not run if its false.

**Where did you use a `do-while` loop in this assignment and why?**
Answer:I used a do-while loop in the ReadIntInRange to keep asking the user for input until they enter a valid number thats within range.

**Where did you use a `while` loop and why?**
Answer:I used a while loop in the guessing part of the game to keep in order for it to keep asking for guesses until the user guesses the correct number.

**Where did you use a `for` loop and why?**
Answer:I used a for loop to repeat the game for each round asked because the number of rounds is set/chosen by the user.

## Input Validation

**Why did you create a helper method for input validation?**
Answer:I made a helper method so I didn’t have to repeat the same input validation code twice.

**How did you make sure the max value was between 10 and 100?**
Answer:I used the ReadIntInRange method with a minimum of 10 and a maximum of 100. It will keep looping until the value given in within range.

**How did you make sure the number of rounds was between 1 and 3?**
Answer:I used the ReadIntInRange method with a minimum of 1 and a maximum of 3. It will keep looping until the value given is within range.

**How did you handle invalid input (non-numbers)?**
Answer:I used int.TryParse. If the input is not a number, it returns false, and the loop continues until a valid number is entered.

## Guessing Logic

**How did you compare the guess to the secret number?**
Answer:I used if/else statements. If the guess was lower, I printed “Too low.” If it was higher, I printed “Too high.” If it matched, I printed the correct message; "Correct! You got it in # guesses."

**How did you count the number of guesses?**
Answer:I counted the number of guesses by increasing guessCount each time the user entered a valid guess.
## Random Numbers

**How did you generate the secret number?**
Answer:I created a Random object and used random.Next(1, maxValue + 1) to generate a secret number between 1 and the max value.

**Why does `Random.Next(1, max + 1)` include the max value?**
Answer:adding +1 makes sure the max value is included, without it, the max value would be excluded.

## Testing and Debugging

**What inputs did you test to confirm your loops worked correctly?**
Answer:I tested several numbers outside of range like 1-9 for the max value, numbers above the range like 101, invalid round numbers like 5 and 6, letters like "k" to make sure the loops repeat. I also tested guesses that were too low, too high and correct.

**What bugs or errors did you encounter and fix?**
Answer:I had an error with my if/else statements because of misplaced braces. I fixed it so the feedback worked correctly and the loop ran properly.

## What I Learned

### Key takeaways from this week:

1. Learned how a while loop repeats until a condition is met.
2. Learned that a simple error like misplaced braces can break the program.
3. Learned that input validation prevents crashes.

**Which loop felt most natural to use and why?**
Answer:The while loop felt the most natural because it keeps repeating until the correct guess is made. This is exactly how the game is supposed to work.

## Time Spent

**Total time:** 2.5 hours

**Breakdown:**

- Planning the loops: 0.5 hours
- Input validation: 0.5 hours
- Guessing logic: 0.5 hours
- Testing and debugging: 0.75 hours
- Writing documentation: 0.75 hours

**Most time-consuming part:**
Answer:Testing and debugging because small logic and brace mistakes caused errors that I had to track down and fix.

## Reflection

**What would you do differently next time?**
Answer:I would run the tests after each small change so I can catch errors earlier.

**How did using three different loop types improve your understanding of repetition?**
Answer:using three different loop types helped me understand how each loop is used in different situation, it depends on whether the repetition is fixed, unknown or needs to run at least once.
