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