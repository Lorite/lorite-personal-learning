# Introduction
Leetcode problems are a great way to practice coding and problem solving skills. This repository contains a collection of lists of Leetcode problems that I have completed. I follow a Test Driven Development (TDD) approach and good design practices as much as I can. I also try to optimize the solutions regarding time and space complexity and edge cases. To implement different solutions for the same problem in a given language, I use the Strategy design pattern. It lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable. Strategy lets the algorithm vary independently from clients that use it.

# Workflow
1. Copy the problem description from Leetcode to this repository in the `<problem>/description.md` file. I first temporarily copy the problem description to Obsidian to keep the linting and formatting, and then copy it to this repository. Also copy the initial code (if any) to this repository in the `<problem>/solution_<language_file_extension>.<language_file_extension>`.
2. Read the problem description and understand the problem.
3. Think of a brute force solution.
4. Write tests for the solution in this repository in the `<problem>/test_<language_file_extension>.<language_test_file_extension>` file.
5. Write the logic on this repository in the `<problem>/solution_<language_file_extension>.<language_file_extension>`. Leetcode autocomplete is only available for premium users.
6. Copy the solution to Leetcode and submit it. This is to check if the solution and tests are correct.
7. Copy the result from Leetcode to this repository in the `<problem>/results.md` file.
8. Optimize the solution regarding time and space complexity and edge cases, and repeat steps 4-7.
9. Commit the changes to this repository.

# Language specific notes and how to run the code

## C++
For C++, I use the [Google Test](http://google.github.io/googletest/) framework for testing. I find [value-parametrized tests](http://google.github.io/googletest/advanced.html#how-to-write-value-parameterized-tests) very useful for testing Leetcode problems. For building and running the tests, I use [Bazel](https://bazel.build/). To run the tests, run the following command in the terminal:
```bash
bazel test //src/exercises/leetcode/<problem>:solution_test
```

# Collection of lists of Leetcode problems

## [Grind 75](https://www.techinterviewhandbook.org/grind75) (more updated than Blind 75 by the same author)
### Array
| Exercise | Difficulty | Estimated Time |
| -------- | ---------- | -------------- |
| [Two Sum](https://leetcode.com/problems/two-sum) | Easy | 15 mins |
| [Best Time to Buy and Sell Stock](https://leetcode.com/problems/best-time-to-buy-and-sell-stock) | Easy | 20 mins |
| [Majority Element](https://leetcode.com/problems/majority-element) | Easy | 20 mins |
| [Contains Duplicate](https://leetcode.com/problems/contains-duplicate) | Easy | 15 mins |
| [Insert Interval](https://leetcode.com/problems/insert-interval) | Medium | 25 mins |
| [3Sum](https://leetcode.com/problems/3sum) | Medium | 30 mins |
| [Product of Array Except Self](https://leetcode.com/problems/product-of-array-except-self) | Medium | 30 mins |
| [Combination Sum](https://leetcode.com/problems/combination-sum) | Medium | 30 mins |
| [Merge Intervals](https://leetcode.com/problems/merge-intervals) | Medium | 30 mins |
| [Sort Colors](https://leetcode.com/problems/sort-colors) | Medium | 25 mins |
| [Container With Most Water](https://leetcode.com/problems/container-with-most-water) | Medium | 35 mins |

### Stack
| Exercise | Difficulty | Estimated Time |
| -------- | ---------- | -------------- |
| [Valid Parentheses](https://leetcode.com/problems/valid-parentheses) | Easy | 20 mins |
| [Implement Queue using Stacks](https://leetcode.com/problems/implement-queue-using-stacks) | Easy | 20 mins |
| [Evaluate Reverse Polish Notation](https://leetcode.com/problems/evaluate-reverse-polish-notation) | Medium | 30 mins |
| [Min Stack](https://leetcode.com/problems/min-stack) | Medium | 20 mins |
| [Trapping Rain Water](https://leetcode.com/problems/trapping-rain-water) | Hard | 35 mins |
| [Basic Calculator](https://leetcode.com/problems/basic-calculator) | Hard | 40 mins |
| [Largest Rectangle in Histogram](https://leetcode.com/problems/largest-rectangle-in-histogram) | Hard | 35 mins |

### Linked List
| Exercise | Difficulty | Estimated Time |
| -------- | ---------- | -------------- |
| [Merge Two Sorted Lists](https://leetcode.com/problems/merge-two-sorted-lists) | Easy | 20 mins |
| [Linked List Cycle](https://leetcode.com/problems/linked-list-cycle) | Easy | 20 mins |
| [Reverse Linked List](https://leetcode.com/problems/reverse-linked-list) | Easy | 20 mins |
| [Middle of the Linked List](https://leetcode.com/problems/middle-of-the-linked-list) | Easy | 20 mins |
| [LRU Cache](https://leetcode.com/problems/lru-cache) | Medium | 30 mins |

### String
| Exercise | Difficulty | Estimated Time |
| -------- | ---------- | -------------- |
| [Valid Palindrome](https://leetcode.com/problems/valid-palindrome) | Easy | 15 mins |
| [Valid Anagram](https://leetcode.com/problems/valid-anagram) | Easy | 15 mins |
| [Longest Palindrome](https://leetcode.com/problems/longest-palindrome) | Easy | 20 mins |
| [Longest Substring Without Repeating Characters](https://leetcode.com/problems/longest-substring-without-repeating-characters) | Medium | 30 mins |
| [String to Integer (atoi)](https://leetcode.com/problems/string-to-integer-atoi) | Medium | 25 mins |
| [Longest Palindromic Substring](https://leetcode.com/problems/longest-palindromic-substring) | Medium | 25 mins |
| [Find All Anagrams in a String](https://leetcode.com/problems/find-all-anagrams-in-a-string) | Medium | 30 mins |
| [Minimum Window Substring](https://leetcode.com/problems/minimum-window-substring) | Hard | 30 mins |

### Binary Tree
| Exercise | Difficulty | Estimated Time |
| -------- | ---------- | -------------- |
| [Invert Binary Tree](https://leetcode.com/problems/invert-binary-tree) | Easy | 15 mins |
| [Balanced Binary Tree](https://leetcode.com/problems/balanced-binary-tree) | Easy | 15 mins |
| [Diameter of Binary Tree](https://leetcode.com/problems/diameter-of-binary-tree) | Easy | 30 mins |
| [Maximum Depth of Binary Tree](https://leetcode.com/problems/maximum-depth-of-binary-tree) | Easy | 15 mins |
| [Binary Tree Level Order Traversal](https://leetcode.com/problems/binary-tree-level-order-traversal) | Medium | 20 mins |
| [Lowest Common Ancestor of a Binary Tree](https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree) | Medium | 25 mins |
| [Binary Tree Right Side View](https://leetcode.com/problems/binary-tree-right-side-view) | Medium | 20 mins |
| [Construct Binary Tree from Preorder and Inorder Traversal](https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal) | Medium | 25 mins |
| [Serialize and Deserialize Binary Tree](https://leetcode.com/problems/serialize-and-deserialize-binary-tree) | Hard | 40 mins |

### Binary Search
| Exercise | Difficulty | Estimated Time |
| -------- | ---------- | -------------- |
| [Binary Search](https://leetcode.com/problems/binary-search) | Easy | 15 mins |
| [First Bad Version](https://leetcode.com/problems/first-bad-version) | Easy | 20 mins |
| [Search in Rotated Sorted Array](https://leetcode.com/problems/search-in-rotated-sorted-array) | Medium | 30 mins |
| [Time Based Key-Value Store](https://leetcode.com/problems/time-based-key-value-store) | Medium | 35 mins |
| [Maximum Profit in Job Scheduling](https://leetcode.com/problems/maximum-profit-in-job-scheduling) | Hard | 45 mins |

### Graph
| Exercise | Difficulty | Estimated Time |
| -------- | ---------- | -------------- |
| [Flood Fill](https://leetcode.com/problems/flood-fill) | Easy | 20 mins |
| [01 Matrix](https://leetcode.com/problems/01-matrix) | Medium | 30 mins |
| [Clone Graph](https://leetcode.com/problems/clone-graph) | Medium | 25 mins |
| [Course Schedule](https://leetcode.com/problems/course-schedule) | Medium | 30 mins |
| [Number of Islands](https://leetcode.com/problems/number-of-islands) | Medium | 25 mins |
| [Rotting Oranges](https://leetcode.com/problems/rotting-oranges) | Medium | 30 mins |
| [Accounts Merge](https://leetcode.com/problems/accounts-merge) | Medium | 30 mins |
| [Word Search](https://leetcode.com/problems/word-search) | Medium | 30 mins |
| [Minimum Height Trees](https://leetcode.com/problems/minimum-height-trees) | Medium | 30 mins |
| [Word Ladder](https://leetcode.com/problems/word-ladder) | Hard | 45 mins |

### Binary Search Tree
| Exercise | Difficulty | Estimated Time |
| -------- | ---------- | -------------- |
| [Lowest Common Ancestor of a Binary Search Tree](https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree) | Easy | 20 mins |
| [Validate Binary Search Tree](https://leetcode.com/problems/validate-binary-search-tree) | Medium | 20 mins |
| [Kth Smallest Element in a BST](https://leetcode.com/problems/kth-smallest-element-in-a-bst) | Medium | 25 mins |

### Hash Table
| Exercise | Difficulty | Estimated Time |
| -------- | ---------- | -------------- |
| [Ransom Note](https://leetcode.com/problems/ransom-note) | Easy | 15 mins |

### Dynamic Programming
| Exercise | Difficulty | Estimated Time |
| -------- | ---------- | -------------- |
| [Climbing Stairs](https://leetcode.com/problems/climbing-stairs) | Easy | 20 mins |
| [Maximum Subarray](https://leetcode.com/problems/maximum-subarray) | Medium | 20 mins |
| [Coin Change](https://leetcode.com/problems/coin-change) | Medium | 25 mins |
| [Partition Equal Subset Sum](https://leetcode.com/problems/partition-equal-subset-sum) | Medium | 30 mins |
| [Unique Paths](https://leetcode.com/problems/unique-paths) | Medium | 20 mins |

### Binary
| Exercise | Difficulty | Estimated Time |
| -------- | ---------- | -------------- |
| [Add Binary](https://leetcode.com/problems/add-binary) | Easy | 15 mins |

### Heap
| Exercise | Difficulty | Estimated Time |
| -------- | ---------- | -------------- |
| [K Closest Points to Origin](https://leetcode.com/problems/k-closest-points-to-origin) | Medium | 30 mins |
| [Task Scheduler](https://leetcode.com/problems/task-scheduler) | Medium | 35 mins |
| [Find Median from Data Stream](https://leetcode.com/problems/find-median-from-data-stream) | Hard | 30 mins |
| [Merge k Sorted Lists](https://leetcode.com/problems/merge-k-sorted-lists) | Hard | 30 mins |

### Trie
| Exercise | Difficulty | Estimated Time |
| -------- | ---------- | -------------- |
| [Implement Trie (Prefix Tree)](https://leetcode.com/problems/implement-trie-prefix-tree) | Medium | 35 mins |
| [Word Break](https://leetcode.com/problems/word-break) | Medium | 30 mins |

### Recursion
| Exercise | Difficulty | Estimated Time |
| -------- | ---------- | -------------- |
| [Permutations](https://leetcode.com/problems/permutations) | Medium | 30 mins |
| [Subsets](https://leetcode.com/problems/subsets) | Medium | 30 mins |
| [Letter Combinations of a Phone Number](https://leetcode.com/problems/letter-combinations-of-a-phone-number) | Medium | 30 mins |

### Matrix
| Exercise | Difficulty | Estimated Time |
| -------- | ---------- | -------------- |
| [Spiral Matrix](https://leetcode.com/problems/spiral-matrix) | Medium | 25 mins |

## Blind 75
### Array

- [Two Sum](https://leetcode.com/problems/two-sum/)
- [Best Time to Buy and Sell Stock](https://leetcode.com/problems/best-time-to-buy-and-sell-stock/)
- [Contains Duplicate](https://leetcode.com/problems/contains-duplicate/)
- [Product of Array Except Self](https://leetcode.com/problems/product-of-array-except-self/)
- [Maximum Subarray](https://leetcode.com/problems/maximum-subarray/)
- [Maximum Product Subarray](https://leetcode.com/problems/maximum-product-subarray/)
- [Find Minimum in Rotated Sorted Array](https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/)
- [Search in Rotated Sorted Array](https://leetcode.com/problems/search-in-rotated-sorted-array/)
- [3 Sum](https://leetcode.com/problems/3sum/)
- [Container With Most Water](https://leetcode.com/problems/container-with-most-water/)

---

### Binary

- [Sum of Two Integers](https://leetcode.com/problems/sum-of-two-integers/)
- [Number of 1 Bits](https://leetcode.com/problems/number-of-1-bits/)
- [Counting Bits](https://leetcode.com/problems/counting-bits/)
- [Missing Number](https://leetcode.com/problems/missing-number/)
- [Reverse Bits](https://leetcode.com/problems/reverse-bits/)

---

### Dynamic Programming

- [Climbing Stairs](https://leetcode.com/problems/climbing-stairs/)
- [Coin Change](https://leetcode.com/problems/coin-change/)
- [Longest Increasing Subsequence](https://leetcode.com/problems/longest-increasing-subsequence/)
- [Longest Common Subsequence](https://leetcode.com/problems/longest-common-subsequence/)
- [Word Break Problem](https://leetcode.com/problems/word-break/)
- [Combination Sum](https://leetcode.com/problems/combination-sum-iv/)
- [House Robber](https://leetcode.com/problems/house-robber/)
- [House Robber II](https://leetcode.com/problems/house-robber-ii/)
- [Decode Ways](https://leetcode.com/problems/decode-ways/)
- [Unique Paths](https://leetcode.com/problems/unique-paths/)
- [Jump Game](https://leetcode.com/problems/jump-game/)

---

### Graph

- [Clone Graph](https://leetcode.com/problems/clone-graph/)
- [Course Schedule](https://leetcode.com/problems/course-schedule/)
- [Pacific Atlantic Water Flow](https://leetcode.com/problems/pacific-atlantic-water-flow/)
- [Number of Islands](https://leetcode.com/problems/number-of-islands/)
- [Longest Consecutive Sequence](https://leetcode.com/problems/longest-consecutive-sequence/)
- [Alien Dictionary (Leetcode Premium)](https://leetcode.com/problems/alien-dictionary/)
- [Graph Valid Tree (Leetcode Premium)](https://leetcode.com/problems/graph-valid-tree/)
- [Number of Connected Components in an Undirected Graph (Leetcode Premium)](https://leetcode.com/problems/number-of-connected-components-in-an-undirected-graph/)

---

### Interval

- [Insert Interval](https://leetcode.com/problems/insert-interval/)
- [Merge Intervals](https://leetcode.com/problems/merge-intervals/)
- [Non-overlapping Intervals](https://leetcode.com/problems/non-overlapping-intervals/)
- [Meeting Rooms (Leetcode Premium)](https://leetcode.com/problems/meeting-rooms/)
- [Meeting Rooms II (Leetcode Premium)](https://leetcode.com/problems/meeting-rooms-ii/)

---

### Linked List

- [Reverse a Linked List](https://leetcode.com/problems/reverse-linked-list/)
- [Detect Cycle in a Linked List](https://leetcode.com/problems/linked-list-cycle/)
- [Merge Two Sorted Lists](https://leetcode.com/problems/merge-two-sorted-lists/)
- [Merge K Sorted Lists](https://leetcode.com/problems/merge-k-sorted-lists/)
- [Remove Nth Node From End Of List](https://leetcode.com/problems/remove-nth-node-from-end-of-list/)
- [Reorder List](https://leetcode.com/problems/reorder-list/)

---

### Matrix

- [Set Matrix Zeroes](https://leetcode.com/problems/set-matrix-zeroes/)
- [Spiral Matrix](https://leetcode.com/problems/spiral-matrix/)
- [Rotate Image](https://leetcode.com/problems/rotate-image/)
- [Word Search](https://leetcode.com/problems/word-search/)

---

### String

- [Longest Substring Without Repeating Characters](https://leetcode.com/problems/longest-substring-without-repeating-characters/)
- [Longest Repeating Character Replacement](https://leetcode.com/problems/longest-repeating-character-replacement/)
- [Minimum Window Substring](https://leetcode.com/problems/minimum-window-substring/)
- [Valid Anagram](https://leetcode.com/problems/valid-anagram/)
- [Group Anagrams](https://leetcode.com/problems/group-anagrams/)
- [Valid Parentheses](https://leetcode.com/problems/valid-parentheses/)
- [Valid Palindrome](https://leetcode.com/problems/valid-palindrome/)
- [Longest Palindromic Substring](https://leetcode.com/problems/longest-palindromic-substring/)
- [Palindromic Substrings](https://leetcode.com/problems/palindromic-substrings/)
- [Encode and Decode Strings (Leetcode Premium)](https://leetcode.com/problems/encode-and-decode-strings/)

---

### Tree

- [Maximum Depth of Binary Tree](https://leetcode.com/problems/maximum-depth-of-binary-tree/)
- [Same Tree](https://leetcode.com/problems/same-tree/)
- [Invert/Flip Binary Tree](https://leetcode.com/problems/invert-binary-tree/)
- [Binary Tree Maximum Path Sum](https://leetcode.com/problems/binary-tree-maximum-path-sum/)
- [Binary Tree Level Order Traversal](https://leetcode.com/problems/binary-tree-level-order-traversal/)
- [Serialize and Deserialize Binary Tree](https://leetcode.com/problems/serialize-and-deserialize-binary-tree/)
- [Subtree of Another Tree](https://leetcode.com/problems/subtree-of-another-tree/)
- [Construct Binary Tree from Preorder and Inorder Traversal](https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/)
- [Validate Binary Search Tree](https://leetcode.com/problems/validate-binary-search-tree/)
- [Kth Smallest Element in a BST](https://leetcode.com/problems/kth-smallest-element-in-a-bst/)
- [Lowest Common Ancestor of BST](https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/)
- [Implement Trie (Prefix Tree)](https://leetcode.com/problems/implement-trie-prefix-tree/)
- [Add and Search Word](https://leetcode.com/problems/add-and-search-word-data-structure-design/)
- [Word Search II](https://leetcode.com/problems/word-search-ii/)

---

### Heap

- [Merge K Sorted Lists](https://leetcode.com/problems/merge-k-sorted-lists/)
- [Top K Frequent Elements](https://leetcode.com/problems/top-k-frequent-elements/)
- [Find Median from Data Stream](https://leetcode.com/problems/find-median-from-data-stream/)
