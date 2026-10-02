# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?

* Violation of OCP : If you want to add a new shipping carrier, you have to open up this class and modify the method
* Hard coded strings : relying on strings inside a switch statement can easily cause typo errors
* No Polymorphism : we have one method that have all implementation details instead of each carrier do its calculation

- What did you change?

* I Implemented Factory Method which includes the following changes: 
1. Made interface where every carrier implement the calculation from it (applied abstraction)
2. Converted ShippingCostCalculator into an abstract creator class
3. Created creator subclasses : each carrier creator inherit from the base and overrides the factory method to return the object
4. Shifted object Instantiation to subclasses (the core of factory method),
   The base class's Calculate method executes the business logic without knowing which specific carrier it is building

---

## OrderProcessor

- What was the problem?

* Violation of Dependency Inversion: OrderProcessor directly creates its dependencies inside the method,
  This means the high-level module is tightly bound to low-level modules
* Violation of OCP : If you ever want to switch from a SQL database to a MongoDB database, or from SMTP emails to another protocol,
  you have to modify the source code of OrderProcessor
* Hard to test: hardcoding the dependencies make it impossible to test the logic in isolate or fake objects

- What did you change?

* Applied Dependecy Inversion and OCP which includes the following changes: 
1. Created Interfaces for the classes which allow new classes to be added
2. made OrderProcessor depends on abstractions (interfaces) instead of creating the objects directly
(made interfaces inside OrderProcessor and applied the methods through them)
3. Shifted the responsibility of creating and providing the dependencies to the outside (program.cs)


---

## Notifications

- What was the problem?

* Class Explosion: Every time a new feature or modifier is added, you are forced to create multiple new subclasses for every single channel
* Misuse of Inheritance: Inheritance should model an "Is-A" relationship, not to be used for behavior reusability
* Multi-Level inheritance: A change in the parent breaks children (fragile base class)

- What did you change?

* Replaced the Inheritance with compostion and abstraction
Created a abstract base class (NotificationChannel) with simple implementations (EmailChannel and SmsChannel),
 This ensures inheritance is only used for true "Is-A" relationships.
Created a unified Notifier class that accepts a NotificationChannel via composition

* Elminited Class Explosion : Adding a new channel now only requires creating one new NotificationChannel subclass

---

## Proof

- New carrier file(s): ExpressCarrier
- New notification channel file(s): LoggerChannel
- Existing classes left unchanged? (yes/no): yes
