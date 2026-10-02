## Step 3 — One class for both

Error : 'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'T' could be found (are you missing a using directive or an assembly reference?)

- why the compiler rejects it?

* The compiler rejects this because T can represent any type in C#
* At compile time, the compiler has no guarantee that whatever type T is substituted with will actually have an Id property

