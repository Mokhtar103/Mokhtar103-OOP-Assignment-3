## Difference and similarties between the two stores

- What is the same between the two stores

* Same Crud Operations
* Same Data structure (List<T>)

- What is different between them

* StudentStore manages Student objects while, CourseStore manages Course objects



## Step 3 — One class for both

Error : 'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'T' could be found (are you missing a using directive or an assembly reference?)

- why the compiler rejects it?

* The compiler rejects this because T can represent any type in C#
* At compile time, the compiler has no guarantee that whatever type T is substituted with will actually have an Id property


## Step 7 — Prove it in Main

- Why new Store<string>() does not compile?

* the store class includes a constraint where T : IHasId which means,
that T must be a type that implements IHasId interface
while string is a built-in class that doesn't implement IHasId, so the compiler will show an error

## Common name for the kind of class i built

- Generic Repository: it is used to put data operations in one place (add, getbyid, remove, getall),
  so you dont rewrite them for every single entity