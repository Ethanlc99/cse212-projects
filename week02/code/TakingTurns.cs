public static class TakingTurns {
    public static void Test() {
        // TODO Problem 1 - Run test cases and fix the code to match requirements
        // Test Cases

        // Test 1
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3) and
        // run until the queue is empty
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
        Console.WriteLine("Test 1");
        var players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);
        // Console.WriteLine(players);    // This can be un-commented out for debug help
        while (players.Length > 0)
            players.GetNextPerson();
        // Defect(s) Found: AddPerson was adding people to the front of the line, instead of the back. This was because the Enqueue function was inserting people to index 1 instead of Adding them, which would put them at the back

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3)
        // After running 5 times, add George with 3 turns.  Run until the queue is empty.
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, George, Sue, Tim, George, Tim, George
        Console.WriteLine("Test 2");
        players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);
        for (int i = 0; i < 5; i++) {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }

        players.AddPerson("George", 3);
        // Console.WriteLine(players);
        while (players.Length > 0)
            players.GetNextPerson();

        // Defect(s) Found: No defects. Any issue with placement or order was fixed when Enqueue was modified

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (Forever), Sue (3)
        // Run 10 times.
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
        Console.WriteLine("Test 3");
        players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 0);
        players.AddPerson("Sue", 3);
        // Console.WriteLine(players);
        for (int i = 0; i < 10; i++) {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }
        // Defect(s) Found: There was no option in AddPerson to make someone with 0 or less defined turns to have infinite terms. Changes it so when AddPerson runs, if the person is difined to have 0 or less turns, they instead had -1 turns. Also changed so that GetNextPerson checks if Person has negative turns, if they do they are added to the queue.

        Console.WriteLine("---------");

         // Test 4
        // Scenario: Create a queue with the following people and turns: Tim (Forever), Sue (3)
        // Run 10 times.
        // Expected Result: Tim, Sue, Tim, Sue, Tim, Sue, Tim, Tim, Tim, Tim
        Console.WriteLine("Test 4");
        players = new TakingTurnsQueue();
        players.AddPerson("Tim", -3);
        players.AddPerson("Sue", 3);
        // Console.WriteLine(players);
        for (int i = 0; i < 10; i++) {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }
        // Defect(s) Found: No errors. All defects were solved when Test 3 was resolved. 

        Console.WriteLine("---------");

        // Test 5
        // Scenario: Try to get the next person from an empty queue
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 5");
        players = new TakingTurnsQueue();
        players.GetNextPerson();
        // Defect(s) Found:
    }
}