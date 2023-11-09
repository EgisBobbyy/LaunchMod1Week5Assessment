# Mod 1 Week 5 Assessment

## Questions (10 Points Possible)

1. What would happen if you try to use a variable that is not in scope?

ANSWER: You would receive a compiler error, as scope defines the limits of responsibility for a given code block. If the code is not within scope, it is essentially unreachable by other pieces of code.  

2. Describe the three As of a test:
3. 
A -   Arrange: setting up the test and the initital conditions for the test, if not set up properly, it would be difficult to find the specific purpose of the code, and would be very unreliable, or not work at all.

A -   Act: the behavior or action is being executed, if not made properly, it will not do its expected purpose, making the test pointless.

A -   Assert: validifies the action that is supposed to happen within the code, if not done, there will be no confirmation that the code is working as intended.

4. What is the difference between `public` and `private` access modifiers?

ANSWER: A 'public' access modifier can be accessed from outside the class, while a 'private' may only be accessed from within the class. This is an essential part of 'scope' mentioned earlier, assigning responsibilites of what can be accessed from where.

5. A method should:  (**Select all that apply**) <br/>

(A) Make changes to an object  <====

(B) Return some information about an object  <====

(C) Make changes to an object and return information about the object.  
(D) None of the Above.  

ANSWER: (A) and (B).

6. How did you determine what to answer for the question above?

ANSWER: A well-written method should do one of two things: give us some information (query) or change some information (command). While a method could do both at the same time, it is a bad practice to assign too much responsibility to a single method.

## Exercise (10 Points Possible)

Clone your forked copy of this repository into Visual Studio.  

In this solution, there is a User project with a single User class.  The class works, but it needs some additional effort to be great! One thing that is missing is tests; your job is to write the tests that will confirm the functionality of the class. Write one test for the constructor, and at least one test for each of the other 4 methods. As you write the tests, you might find some refactoring opportunities; update the user class with any refactors you deem necessary and add a comment describing why you made that refactor.  The only rule is that all the existing methods must still exist when you are finished!


## Submission

When finished:
* Commit your changes in Visual Studio
* Push up to GitHub
