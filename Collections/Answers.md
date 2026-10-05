## Task 2.1 — Research: IReadOnlyDictionary & SortedDictionary

## IReadOnlyDictionary

1. What is IReadOnlyDictionary<TKey, TValue>

* built-in interface in c# that represents a collection of key/value pairs,
  that only can be read(no modifications)

2. How is it different from Dictionary<TKey, TValue>?

* Dictionary<TKey, TValue> is a concerete class while IReadOnlyDictionary is an interface

* Mutability: A Dictionary allows modification while IReadOnlyDictionary doesn't,
  IReadOnlyDictionary only used for read and it has read operations like
  TryGetValue, ContainsKey, Keys, Values

3. Why return an IReadOnlyDictionary instead of a Dictionary from a public method?

* Applying Encapsulation & Immutability: IReadOnlyDictionary prevents external
  modifications, it allows the caller only to read the data

* Abstraction: By returning an interface rather than a concrete class,
 you keep away the client from your implementation details


## SortedDictionary

1. What is SortedDictionary<TKey, TValue>?

* is a collection of key/value pairs that are automatically sorted by their keys,
  it is implemented using binary search tree

2. How is it different from Dictionary in Ordering?

* Dictionary : Unordered, Items are stored based on hash codes items are iterated or      retrieved can seem random

* SortedDictionary: Sorted, Keys are ordered automatically using  the default comparer for that key type IComparable (you can provide custom one using icomparer)

3. How is it different from Dictionary in Lookup Speed?

* Dictionary: O(1) average since it uses a hash table
* SortedDictionary: o(log n) since it relies on tree structure

4. When would you choose SortedDictionary?

* When you need ordered data

* When you data to be inserted in a sorted order, SortedDictionary handles this automatically without requiring you to manually sort a list or array after every batch of updates

## Task 2.2 — Pick the Collection

1. S1 => Hashet or dictionary (if it is key/value pair), both provides o(1) avg time complexity

2. S2 => Hashet, it removes duplicates

3. S3 => List, it maintains insertion order and allows duplicate elements

4. S4 => IReadOnlyDictionary, It allows only read operations

5. S5 => SortedDictionary, automatically sorts its elements by key as items are added at any moment

6. S6 => IEnumerable, enables lazy evaluation (through yield keyword)