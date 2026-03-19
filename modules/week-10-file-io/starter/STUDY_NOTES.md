# Week 10: Habit Tracker (File I/O) — Study Notes

**Name:** Katherine Ayala

## File I/O — Reading

**What does `File.ReadAllLines` return, and how did you use it?**
Answer: File.ReadAllLines returns a string array. I used it to read all the lines from the CSV file, then loop through each line.

**Why is it important to skip blank lines when reading a CSV file?**
Answer:If a line is blank and you try to split it using ',', it won’t have the expected values. This can cause errors when trying to access parts that don’t exist. Skipping blank lines prevents this.

## File I/O — Writing

**What does `File.WriteAllLines` do, and what arguments does it take?**
[Describe the path argument and what goes in the string array]
Answer:File.WriteAllLines writes multiple lines to a file. It takes a file path and a string array, where each string becomes a line in the file.

**What is `Select(...).ToArray()` doing in `SaveHabits`?**
Answer:Select goes through each habit and turns it into a formatted string. ToArray() converts those results into a string array so it can be used with File.WriteAllLines.

## Exception Handling

**What is a `FileNotFoundException` and when does it occur?**
Answer:A FileNotFoundException happens when the program tries to read a file that does not exist at the path provided.

**Why do we catch `FileNotFoundException` specifically instead of using `catch (Exception)`?**
[Think about what catching all exceptions can hide from you]

Answer:We catch FileNotFoundException to handle missing file errors. Using catch (Exception) can hide other problems like bad data or index errors.

## What I Learned

**Key takeaways from this week:**
[List 3 main things you learned]

1. How to read and write files using File I/O
2. How to use LINQ like Count and Select
3. How to work with CSV data using split and trim

**What was the trickiest part of this assignment and how did you work through it?**

Answer:The trickiest part was reading the CSV file correctly. I worked through it by testing my code step by step.

## Time Spent

**Total time:** 4.5 hours

**Breakdown:**

- Understanding the starter code and CSV formats: 1 hours
- Implementing LoadHabits: 1 hours
- Implementing PrintHabits / PrintSummary: 0.5 hours
- Implementing AddHabit / UpdateHabit / SaveHabits: 1 hours
- Testing and debugging: 0.5 hours
- Writing study notes: 0.5 hours

**Most time-consuming part:**

Answer:Implementing LoadHabits and making sure everything worked correctly.
