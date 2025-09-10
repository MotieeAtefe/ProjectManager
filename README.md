# Strategy Pattern (C#)

## What is Strategy Pattern?
The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable.  
This pattern lets the algorithm vary independently from the clients that use it.  

In simple words:  
Instead of writing multiple `if/else` conditions for different behaviors, we create separate classes for each behavior (strategy).  
The main class (Context) only delegates the work to the chosen strategy.

---

## Example Used Here
Imagine a **Project Manager**:  
- The manager does not know how to code, design, or test.  
- The manager only assigns tasks to employees (strategies).  
- Different employees (Programmer, Designer, Tester) do the work in their own way.  

This is exactly how Strategy Pattern works.

---

## UML Diagram (simplified)
