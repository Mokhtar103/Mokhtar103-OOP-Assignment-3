# Part 02 — answers

---

## Reports

- What was the problem?

* Violation of DRY Principle: same implementation for methods was completely duplicated across all three classes
* Maintenance Overhead: if a business rule is changed in the shared steps, you have to manually update multiple files

- What did you change?

* Created an abstract base class that contains the shared implementations
* Implemented a Template Method in the abstract class which contains sequence of steps
* Defined shared methods as protected so subclasses can inherit the shared behavior
* Declared Format as an abstract method so each subclass provides its own implementations
* Refactored subclasses so now each class contain their unique format logic while inheriting the shared behavior

- Why did you choose that approach?

* Applied the Template Method Pattern: Code Reusability, Enforcing Structure and Reducing Duplication
* Abstract class over Interface : because the abstract class has shared state & Implementation,
  not just a contract with a methods that i want to implement, also it is better in terms of
  template method implementation and it allow us to use access modifiers to hide the shared methods
  while interface force all members to be public, which would expose internal implementation

---

## Enrollment

- What was the problem?

* Tight Coupling: the client has to create and manage each service
* Complexity: To complete a single operation, the caller had the know the sequence and details each service

- What did you change?

* Created facade class: Created a wrapper class that serves as single entry point for the entire enrollment flow
* Moved the creation of objects and method calling of services in a single method
* the caller can preform the entire enrollment operation with a single method call

- Why did you choose that approach?

* The facade pattern is specifically designed to provide a simplified interface to a complex subsystem,
  hiding internal implementation details from the client, and reduce tight coupling

* Improve maintainability and reusability: By putting the workflow in a single class,
  the code became easier to maintaind, read and test while services are untouched
