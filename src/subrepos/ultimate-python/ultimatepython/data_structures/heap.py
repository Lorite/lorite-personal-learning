import heapq


def main():
    # Define the list of numbers
    nums = [3, 1, 4, 1, 5]

    # Creating a min-heap
    min_heap = []
    for num in nums:
        heapq.heappush(min_heap, num)
    assert min_heap[0] == 1  # The root of the heap is the smallest element

    # Pop the smallest element
    smallest = heapq.heappop(min_heap)
    assert smallest == 1

    # Adding a new element
    heapq.heappush(min_heap, 5)
    assert min_heap[0] == 1  # The root remains the smallest element

    # Creating a max-heap
    max_heap = []
    for num in nums:
        heapq.heappush(max_heap, -num)  # Negate numbers for a max-heap
    assert -max_heap[0] == 5  # The root of the heap is the largest element

    # Pop the largest element
    largest = -heapq.heappop(max_heap)
    assert largest == 5

    # Converting a list to a heap in-place
    data = [3, 1, 4, 1, 5]
    heapq.heapify(data)
    assert data[0] == 1  # The root is the smallest element

    # Extending a heap
    more_data = [2, 6, 5]
    for item in more_data:
        heapq.heappush(data, item)
    assert data[0] == 1  # The root is still the smallest element

    # Using heap for sorting
    sorted_data = [heapq.heappop(data) for _ in range(len(data))]
    assert sorted_data == [1, 1, 2, 3, 4, 5, 5, 6]

    # Getting the n smallest or largest elements from a list
    n_smallest = heapq.nsmallest(3, nums)  # Get the 3 smallest elements
    assert n_smallest == [1, 1, 3]

    n_largest = heapq.nlargest(3, nums)  # Get the 3 largest elements
    assert n_largest == [5, 4, 3]

    # Merging multiple sorted lists into a single sorted list using a heap
    list1 = [1, 3, 5, 7]
    list2 = [2, 4, 6, 8]
    merged_list = list(heapq.merge(list1, list2))
    assert merged_list == [1, 2, 3, 4, 5, 6, 7, 8]


if __name__ == "__main__":
    main()
