#include <cstdint>
#include <iostream>
#include <lorite_utils/easy_printing.hpp>
#include <vector>

using EP = lorite_utils::EasyPrinting;

int main() {
  // std::vector
  std::vector<int> v{1, 2, 3, 4, 5};
  v.reserve(10);  // pre-allocate memory for 10 elements
  std::cout << "v: " << EP::vector_to_string(v) << '\n';
  std::cout << "v.size(): " << v.size() << '\n';
  std::cout << "v.capacity(): " << v.capacity() << '\n';
  std::cout << "v.max_size(): " << v.max_size() << '\n';
  std::cout << "v.empty(): " << v.empty() << '\n';
  std::cout << "v.data(): " << v.data() << '\n';
  std::cout << "v.front(): " << v.front() << '\n';
  std::cout << "v.back(): " << v.back() << '\n';
  std::vector<int> v2{6, 7, 8, 9, 10};
  std::cout << "v2: " << EP::vector_to_string(v2) << '\n';
  v.insert(v.end(), v2.begin(), v2.end());
  std::cout << "v after inserting v2 into it: " << EP::vector_to_string(v)
            << '\n';

  return 0;
}

/* Notes:
- Check the previous source files for notes on things not mentioned here.
- Memory Model:
  - C++'s language specification is based on an abstract memory model. Concrete
implementations (= compiler, C++ runtime, …) can employ different strategies to
satisfy these specifications on a concrete platform (= CPU architecture,
operating system, …).
  - Memory Organisation: memory is divided into bytes. An object is a piece of
memory.
  - Object Storage Duration Types:
    - Automatic: object lifetime tied to start & end of { … } block scopes. -
local variables, function parameters.
    - Dynamic: object lifetime controlled with special instructions. - objects
that can be created/destroyed on demand and independent of block scopes.
    - Thread: object lifetime tied to start & end of a thread. - per-thread
storage.
    - Static: object lifetime tied to start & end of the program. -
singletons, global variables.
  - In modern C++, manual allocation is actually only really necessary if you
want to implement your own dynamic data structures / containers.
- Common Solution: Dedicated Memory Partitions For Automatic/Dynamic Storage
Durations:
  - Heap = Free Store:
    - used for objects of dynamic storage duration, e.g. the contents of a
std::vector, std::map, …
    - big, can be used for bulk storage (most of main memory).
    - possible to allocate & deallocate any object on demand.
    - (de-)allocations in no particular order ⇒ fragmentation.
    - slow allocation: need to find contiguous unoccupied space for new objects.
  - Stack:
    - used for objects of automatic storage duration: local variables, function
parameters, etc.
    - small (usually only a few MB).
    - fast allocation: new objects are always put on top.
    - objects de-allocated in reverse order of their creation.
    - can't de-allocate objects below the topmost (= newest).
- std::vector:
  - Memory Layout:
    - Each vector object holds a separate buffer that is dynamically allocated
(on the heap) where the actual content is stored.
    - Right now we only know how to allocate objects on the stack, but the
vector object v itself could also be allocated on the heap (more on that in
later chapters).
  - Growth Scheme:
    - Memory blocks, once allocated, can't be resized! (no guarantee that there
is space left directly behind previously allocated memory block).
    - Dynamic array implementations separate the array object from the actual
memory block for storing values.
  - Size vs Capacity:
    - size: number of elements currently stored in the vector.
    - capacity: number of elements that can be stored in the vector without
  - Use reserve() to pre-allocate memory for a vector if you know the
approximate number of elements in advance. It avoids unnecessary reallocations
and copies during the growth phase.
*/
