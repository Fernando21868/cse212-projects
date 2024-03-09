using System.Diagnostics;

public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

         // Test 1
        Console.WriteLine("Test 1");
        // Scenario: Enqueue items with different priorities
        // Expected Result: Items dequeued in the order of their priority
        priorityQueue.Enqueue("Item 1", 3);
        priorityQueue.Enqueue("Item 2", 1);
        priorityQueue.Enqueue("Item 3", 2);
        var result = priorityQueue.Dequeue();
        Console.WriteLine(result);
        Trace.Assert(result == "Item 1");

        result = priorityQueue.Dequeue();
        Console.WriteLine(result);
        Trace.Assert(result == "Item 3");

        result = priorityQueue.Dequeue();
        Console.WriteLine(result);
        Trace.Assert(result == "Item 2");
        
        // Defect(s) Found: 
        // When I returned the element I also had to remove it from the queue, and I wasn't doing this.
        // The comparison symbol in the For loop must be of the type less than or equal and not just less.
        Console.WriteLine("---------");

        // Test 2
        Console.WriteLine("Test 2");
        // Scenario: Enqueue items with same priority
        // Expected Result: Items dequeued in the order they were enqueued
        priorityQueue.Enqueue("Item 1", 2);
        priorityQueue.Enqueue("Item 2", 2);
        priorityQueue.Enqueue("Item 3", 3);
        priorityQueue.Enqueue("Item 4", 4);
        priorityQueue.Enqueue("Item 5", 5);
        priorityQueue.Enqueue("Item 6", 6);
        priorityQueue.Enqueue("Item 7", 3);

        result = priorityQueue.Dequeue();
        Console.WriteLine(result);
        Trace.Assert(result == "Item 6");

        result = priorityQueue.Dequeue();
        Console.WriteLine(result);
        Trace.Assert(result == "Item 5");

        result = priorityQueue.Dequeue();
        Console.WriteLine(result);
        Trace.Assert(result == "Item 4");

        result = priorityQueue.Dequeue();
        Console.WriteLine(result);
        Trace.Assert(result == "Item 3");

        result = priorityQueue.Dequeue();
        Console.WriteLine(result);
        Trace.Assert(result == "Item 7");

        result = priorityQueue.Dequeue();
        Console.WriteLine(result);
        Trace.Assert(result == "Item 1");

        result = priorityQueue.Dequeue();
        Console.WriteLine(result);
        Trace.Assert(result == "Item 2");
        
        // Defect(s) Found:
        // When assigning the index of the element to be returned, it did not compare whether or not the element was equal to another element with the same priority
        // When I returned the element I also had to remove it from the queue, and I wasn't doing this.
        // The comparison symbol in the For loop must be of the type less than or equal and not just less.
        Console.WriteLine("---------");

        // Test 3
        Console.WriteLine("Test 3");
        // Scenario: Dequeue from an empty queue
        // Expected Result: Error message "The queue is empty."
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: 
        // No defects found
        Console.WriteLine("---------");

        // Test 4
        Console.WriteLine("Test 4");
        // Scenario: Enqueue items in random order
        // Expected Result: Items dequeued in the correct priority order
        priorityQueue.Enqueue("Item 7", 5);
        priorityQueue.Enqueue("Item 8", 1);
        priorityQueue.Enqueue("Item 9", 3);
        
        result = priorityQueue.Dequeue();
        Console.WriteLine(result);
        Trace.Assert(result == "Item 7");
        
        result = priorityQueue.Dequeue();
        Console.WriteLine(result);
        Trace.Assert(result == "Item 9");
        
        result = priorityQueue.Dequeue();
        Console.WriteLine(result);
        Trace.Assert(result == "Item 8");

        // Defect(s) Found: 
        // When I returned the element I also had to remove it from the queue, and I wasn't doing this.
        // The comparison symbol in the For loop must be of the type less than or equal and not just less.
        Console.WriteLine("---------");

    }
}