# Part 03 — answers

---

## BlockedUsers

- Time complexity before: O(m x n)
- Time (ms) before: 32
- What did you change?

* Replaced List with hashset because Contain in hashet => o(1) amortized while Contain in list => O(n)

- Time complexity after: O(m + n)
- Time (ms) after: 2

---

## Students

- What was the problem?

* Wasted Resources: using the normal return we are still creating million objects of student in the memory all at once,
  even if the caller wants 3 students only


- What did you change?

* Switched to Lazy Execution: change the return type from list to IEnumerable through which
  can utilize the yield return which generates students objects on demand,
  so when the caller wanted 3 objects, only 3 objects are created