public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Create a queue with these people and their priority: John - 2, Bill - 1, Joel - 3
        // Expected Result: Henry, John, Joel, Bill
        Console.WriteLine("Test 1");
        var people = new PriorityQueue();
        people.Enqueue("John", 2);
        people.Enqueue("Bill", 1);
        people.Enqueue("Joel", 3);
        people.Dequeue();
        people.Dequeue();
        people.Dequeue();
        
        // Defect(s) Found: Wasn't printing the value (name) when Dequeueing it - told program to print the value that is returned from the Dequeue function. Isn't removing name from Queue when Dequeueing - Made code remove item that it was dequeueing before returning the value. Isn't removing name with the highest priority - Dequeue wasn't checking all items in Queue, so made sure that it was checking each item by changing the < to <= in the for loop logic.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a Queue with these people and priorities: John - 2, Bill, - 1, Joel - 3, Henry -2, Jessica - 3, Walmart - 2, Jo-Jo 3
        // Expected Result: Joel, Jessica, Jo-Jo, John, Henry, Walmart, Bill
        Console.WriteLine("Test 2");
        people.Enqueue("John", 2);
        people.Enqueue("Bill", 1);
        people.Enqueue("Joel", 3);
        people.Enqueue("Henry", 2);
        people.Enqueue("Jessica", 3);
        people.Enqueue("Walmart", 2);
        people.Enqueue("Jo-Jo", 3);
        people.Dequeue();
        people.Dequeue();
        people.Dequeue();
        people.Dequeue();
        people.Dequeue();
        people.Dequeue();
        people.Dequeue();
        // Defect(s) Found: Dequeue was removing names with the same priority as the first item before the first item - Changed the logic when searching for the highest priority to only change when it was higher than, not eaqual to, the currenrly set hghestPriorityIndex. 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}