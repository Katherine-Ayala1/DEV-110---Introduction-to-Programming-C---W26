# Week 8: Mad Libs (Structure + Debugging) - Study Notes

**Name:** Katherine Ayala reyes

## Program Structure

**What helper methods did you create (and what does each one do)?**
Answer: I created ChooseTemplate to let the user select which story to use. CollectWords gathers all the words based on the prompts. ReadYesNo checks for valid y/n input. ReadIntInRange makes sure the user enters a number within a specific range. ReadNonEmptyString prevents empty or blank input.

**Why is it helpful to move code out of `Main` and into helper methods?**
Answer:It’s helpful to move code out of Main because it makes the program easier to read and follow. Each helper method does one small job, which makes the code clearer and easier to fix if something goes wrong.

## Data Modeling

**What is the purpose of the `StoryTemplate` class in this assignment?**
Answer:The StoryTemplate class stores the story title, the list of prompts, and the template text with placeholders. It keeps all the story information together so the program can generate different stories in an organized way.

**How did using a template make it easier to support two different stories?**
Answer:Using a template made it easier because the program uses the same steps to collect words and build the story. The only difference is the prompts and the story text. This way, I didn’t have to rewrite the logic for each story.

## Testing and Debugging

**Where did you set a breakpoint while debugging this program (what line or method)?**
Answer:I set a breakpoint at the beginning of the CollectWords method to see how the words were being stored. I also set one in ChooseTemplate to check how the program handled invalid input.

**What did you learn from stepping through your code line by line?**
Answer:I learned how the program runs step by step and how each method connects to the next. It helped me see how user input was stored and where mistakes were happening so I could fix them.

**What bug or logic mistake did you encounter (and how did you fix it)?**
Answer:At first, my ReadYesNo method was returning the wrong value for "y". This caused the play-again loop to stop when it should have continued. I fixed it by correcting the return value so "y" returns true and "n" returns false.

## What I Learned

**Key takeaways from this week:**

1. that using the StoryTemplate class keeps story data organized.
2. that placeholders like {0} and {1} make stories dynamic.
3. Learned that separating story data from logic keeps the program cleaner.

**What part of this assignment helped you understand program structure the most?**
Answer:Breaking the program into helper methods helped me understand program structure the most. It showed me how each part of the program has its own job and how everything works together.

## Time Spent

**Total time:** 3.5 hours

**Breakdown:**

- Planning structure (methods/classes): 1 hours
- Input validation: 0.5 hours
- Story templates + formatting: 1 hours
- Testing and debugging: 0.75 hours
- Writing documentation: 0.25 hours

**Most time-consuming part:**
Answer:Testing and debugging took the longest because I had to adjust my validation loops and fix small logic mistakes to make the tests pass.

## Reflection

**What would you improve if you had more time?**
Answer:If I had more time, I would add more story templates and improve the formatting to make the final story look cleaner. I would also make the prompts more creative.

**How did breaking your program into smaller parts help you debug?**
Answer:Breaking the program into smaller parts made it easier to find problems. I could focus on one method at a time instead of searching through the whole program.
