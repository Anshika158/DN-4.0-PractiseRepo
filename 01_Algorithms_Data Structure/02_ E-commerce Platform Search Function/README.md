
# E-commerce Product Search (C#)

This project demonstrates how to search for a product by its ID using two methods: **Linear Search** and **Binary Search**.

---

## Problem Logic

In an e-commerce platform, products are stored in a list. The task is to efficiently find a product based on its unique ID.

### 1. Linear Search
- Goes through each product one by one.
- Works even if the list is not sorted as it search linerely.
- Simple but slower for large lists.
- TIME COMPLEXITY is O(n); as it search each and every element and the worst case maybe is element is at the last

### 2. Binary Search
- Only works if the list is sorted by ID.
- Repeatedly checks the middle element and narrows down the search space.
- We use three variable LOW HIGH AND MID
- Using this we can eliminate LEFT and RIGHT search space respectively and make it faster 
- Much faster for large, sorted lists.
- TIME COMPLEXITY IS O(log n) as it narrow down the left and right search space .

---



