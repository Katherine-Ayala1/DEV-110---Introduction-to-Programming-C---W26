# Week 7: Class Roster Builder (Arrays) - Study Notes

**Name:** Katherine Ayala

## Arrays and `count`

**What are “parallel arrays” and how did you use them in this assignment?**
Answer:parallel arrays are twp arrays that store data at the same index positions. In this assignment I used rosterNames[i] and rosterCredits[i], so each students name and credits stay aligned by index.

**What is the purpose of the `count` variable?**
Answer:The count variable tracks how many students have been added to the roster. It helps determine the next available index and prevents accessing unused array slots.

**Where did you use `count` in loops and why?**
Answer:I used count in loops when printing the roster and when copying the used portion of the arrays for sorting. I looped from 0 to count - 1 instead of the full array length because only the first count elements contain real student data. The rest of the array is unused, so using count prevents printing or processing empty values.

## Printing and Sorting

**How did you print the class roster using a `foreach` loop?**
Answer:I created an array of formatted roster lines, then used a foreach loop to print each line. The foreach loop let me print each student without using indexes.

**How did you sort the roster while keeping names and credits aligned?**
Answer:I copied the used data into new arrays and used Array.Sort on the parallel arrays. This keeps the names and credits matched at the same index after sorting.

## What I Learned

**Key takeaways from this week:**
1. for loops are useful when you need to work with indexes.
2. Arrays store multiple values of the same type using indexes.
3. foreach loops are helpful for printing or reading array values.
4. n/a
5. n/a

**Which loop felt most natural to use and why?**
Answer:for loops felt most natural because I needed the index to add, copy, and sort data in the arrays. It made it easier to control which positions I was working with.

## Time Spent

**Total time:** 3 hours

**Breakdown:**

- Planning the arrays/menu: 0.75 hours
- Input validation: 0.5 hours
- Add + print roster features: 0.75 hours
- Sorting feature: 0.5 hours
- Testing and debugging: 0.25 hours
- Writing documentation: 0.25 hours

**Most time-consuming part:**
Answer:Planning and building the add/print features because I had to make sure the arrays and count worked correctly together.

## Reflection

**What would you do differently next time?**

Answer:Next time I would plan the structure of my arrays and variables more clearly before coding, so I don’t have to reorganize my logic later.

**How did using `for` and `foreach` improve your understanding of arrays?**

Answer:for helped me understand how indexes work in arrays, and foreach helped me easily loop through and print the values.
