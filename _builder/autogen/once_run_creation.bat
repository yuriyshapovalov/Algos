REM should be called once
REM preventing accidancly run
goto exit

; _call_ _FolderName_ _ClassName_ _Namespace_

;Sorting

call create sorting AdaptiveSort Sorting
call create sorting AmericanFlagSort Sorting
call create sorting BeadSort Sorting
call create sorting BubbleSort Sorting
call create sorting BucketSort Sorting
call create sorting BurstSort Sorting
call create sorting CoctailSort Sorting
call create sorting CombSort Sorting
call create sorting CountingSort Sorting
call create sorting CycleSort Sorting
call create sorting FlashSort Sorting
call create sorting GnomeSort Sorting
call create sorting HeapSort Sorting
call create sorting InsertionSort Sorting
call create sorting IntroSort Sorting
call create sorting JSort Sorting
call create sorting LibrarySort Sorting
call create sorting MergeSort Sorting
call create sorting OddEvenSort Sorting
call create sorting PancakeSort Sorting
call create sorting PatienceSort Sorting
call create sorting PigeonholeSort Sorting
call create sorting ProxmaxSort Sorting
call create sorting QuickSort Sorting
call create sorting RadixSort Sorting
call create sorting SimpleSort Sorting
call create sorting SelectionSort Sorting
call create sorting ShellSort Sorting
call create sorting SmoothSort Sorting
call create sorting SpreadSort Sorting
call create sorting StandSort Sorting
call create sorting StoogeSort Sorting
call create sorting TimSort Sorting
call create sorting TournamentSort Sorting
call create sorting TreeSort Sorting
call create sorting UnshuffleSort Sorting

;Lists
call create lists LinkedList Lists
call create lists DoublyLinkedList Lists
call create lists SelfOrganizedList Lists
call create lists SkipList Lists
call create lists UnrolledLinkedList Lists
call create lists VList Lists
call create lists DoublyConnectedEdgeList Lists

; Trees
call create trees AATree Trees
call create trees AVLTree Trees
call create trees BinaryHeap Trees
call create trees CartesianTree Trees
call create trees HashTree Trees
call create trees LLRBTree Trees
call create trees RadixTree Trees
call create trees RedBlackTree Trees
call create trees ScapegoatTree Trees
call create trees SplayTree Trees
call create trees SuffixTree Trees
call create trees TernarySearchTree Trees
call create trees TopTree Trees
call create trees Treap Trees
call create trees TwoThreeTree Trees
call create trees XFastTree Trees
call create trees YFastTree Trees

:exit