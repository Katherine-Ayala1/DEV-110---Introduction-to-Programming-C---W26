# Week 6: Text Menu App - Study Notes

**Name:** Katherine Ayala

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
Answer:A do while loop runs at least one time before checking the condition, a while loop checks the condition first and may not run at all

**Where did you use a `do-while` loop in this assignment and why?**
Answer:I used a do while loop in my input validation methods, it continously asks the user until the input is valid

**Where did you use a `while` loop and why?**
Answer:I used a while loop for the main menu, it repeats until the user chooses the exit option 6

**Where did you use a `for` loop and why?**
Answer:I didn't use a for loop since the program doesnt need to repeat a set number of times.

## Input Validation

**Why did you create a helper method for input validation?**
Answer:It avoids repeating the same code many times, It keeps the program cleaner and easier to read

**How did you validate the menu choice (1–6)?**
Answer: I used a TryParse to check if the input was a number, then checked if the number was 1-6. if its not then its asked again.

**How did you handle invalid input (non-numbers)?**
Answer:I used tryparse, if it fails the program doesn't crash, it shows a message and asks again.

## String Operations

**Which string methods did you use across the different menu options?**
Answer:trim, toUpper, ToLower, replace, split, join, contains, padleft, padright, format, interpolation

**Which four string methods did you demonstrate in Option 6 (String Analysis)?**
Answer: equals, substring, endswith, indexof

**What's the difference between string concatenation and interpolation?**
Answer:Concatenation joins strings using plus, Interpolation inserts variables inside text and Interpolation is easier to read

## What I Learned

**Key takeaways from this week:**
1. Learned how to build a repeating menu
2. Learned how to validate input
3. Learned how to use string methods
4. L
5. L

**Which loop felt most natural to use and why?**
Answer:While loop felt most natural because it controls the menu

## Time Spent

**Total time:** 4 hours

**Breakdown:**

- Planning the loops: 1 hours
- Input validation:  1 hours
- String formatting: 1 hours
- Testing and debugging: 1 hours
- Writing documentation: 1 hours

**Most time-consuming part:**
Answer:Testing and debugging took the longest because I had to match the exact output format required by the tests and fix small mistakes until everything passed.

## Reflection

**What would you do differently next time?**

Answer:Next time I would start earlier and test each menu option one at a time instead of waiting until the end. I would also run the tests more often so I could catch mistakes sooner.

**How did using three different loop types improve your understanding of repetition?**

Answer:Using three different loop types helped me understand when each one makes sense. The while loop is good when you do not know how many times something will repeat. The do while loop is useful when the code needs to run at least once. The for loop is best when you know exactly how many times something should repeat.
