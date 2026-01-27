# Week 2: Calculator Lite - Study Notes

**Name:** Katherine Ayala Reyes

## Understanding Data Types

**What are the four data types you used in this assignment?**
Answer: The four data types used are string, bool, int and double. String stores text such as user input. Bool stores true or false values, int stores whole numbers, which was used for this assignment, Double stores numbers with decimals for calculations.

**Why did we use `double` instead of `int` for the calculations?**
Answer: we used doubles instead of int because doubles can store decimal values. This is important when it comes to math calculations since some may not result in whole numbers, this improves accuracy.

**How do you convert a string to a boolean?**
Answer: if the user input is yes, then the boolean value is set to true. Otherwise it = false.

## Challenges and Solutions

**Biggest challenge with this assignment:**
Answer: For me the hardest part was performing the calculations

**How you solved it:**
Answer:I read the instructions and followed the formulas given. I also tested my code to make sure the calculations worked.

**Most confusing concept:**
Answer: The most confusing concept was the percentage difference formula.

## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**
[Explain what each operator does and give an example]

Answer: the difference is that division gives the result of dividing two numbers. Modulus gives the left overs (remainder) after dividing two numbers. an example is 4/3 = 1.33333.... 4%3 = 1 because
.333.... times 3 = 1

**How do you calculate the average of two numbers?**
[Write the formula in your own words]

Answer: the average is calculated by adding numbers together and dividing it by the total amount of numbers used. e
Ex: (22 + 33) / 2       or (22+33+44) / 3 = average

**What is the formula for percentage difference?**
Answer: the formula ; ((num1 - num2) / num1) * 100 shows how much different the second number is from the first number as a percentage.

## Input and Output

**How do you read user input in C#?**
Answer: we read user input using Console.ReadLine(). It reads what the user types into the console and returns it as a string.

**How do you convert string input to a number?**
Answer:I used double.Parse() to convert the user’s input from a string into a number in order to perform calculations.

**What is string interpolation and how did you use it?**
Answer:string interpolation uses $ and {} in order to insert variables such as the users name or numbers.

## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**
Answer:I used :F2 to show numbers with two decimal places and :F0 to show whole numbers without decimals.

**Why is it important to check for division by zero?**
Answer: Dividing by zero is mathmatically not possible, so it'll cause errors. I made sure to display an error message if it ever happens.

**How did you use the boolean variable to control formatting?**
Answer:I used an if/else statement. If the value was true, the program showed decimals. If it was false, it showed whole numbers.

## What I Learned

**Key takeaways from this week:**
1. how to use if/else statements
2. how to perform math operations in C#
3. how to format output
4. how to store different data types
5. how to read and convert user input

**Which data type concept was most useful?**
Answer: I feel like the double data type was the most useful because it allows decimal calculations which is important to have when it comes to math.

**How does conditional formatting improve user experience?**
Answer:It lets users choose how results are displayed, which makes the program easier to read.

## Testing and Debugging

**What test cases did you use to verify your program works?**
Answer:I tested positive numbers, negative numbers, decimals, zero, and both “yes” and “no” for decimal precision. I also ran dotnet test.

**What bugs or errors did you encounter and fix?**
Answer: I had formating issues at first which I fixed by adjusting the code.

## Time Spent

**Total time:** 3.75 hours

**Breakdown:**

-   Understanding data types: 0.5 hours
-   Reading and parsing user input: 0.5 hours
-   Implementing arithmetic operations: 1.5 hours
-   Adding conditional formatting: 0.5 hours
-   Handling division by zero: 0.25 hours
-   Testing and debugging: 0.25 hours
-   Writing documentation: 0.25 hours

**Most time-consuming part:**

Answer: The calculations section took the longest, since I wasn't sure on how to format it.

## Reflection

**What would you do differently next time?**
Answer:I would run the tests more often while coding to catch mistakes earlier.

**How does this assignment prepare you for more complex programs?**
Answer:These skills are important because it can help us later on when we want to build more complex programs that involve calculations. This assignment helped us understand how different parts of the program work.
