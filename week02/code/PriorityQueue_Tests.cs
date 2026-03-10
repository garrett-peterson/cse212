using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the highest priority being in the last spot
    // Bob(2), Tim(1), Sue(3)
    // Expected Result: Sue, Bob, Tim
    // Defect(s) Found: It wasn't removing the higher priority items first
    public void TestPriorityQueue_1()
    {
        var bob = new PriorityItem("Bob", 2);
        var tim = new PriorityItem("Tim", 1);
        var sue = new PriorityItem("Sue", 3);

        PriorityItem[] expectedResult = [sue, bob, tim];

        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);

        int i = 0;
        int x = 3;
        while (x > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            i++;
            x--;
        }
        
    }

    [TestMethod]
    // Scenario: Have a list where there are several items with the same priority, with one higher and one lower
    // Bob(2), Tim(1), Sue(3), Jan (2), Jon (2), Tom (2)
    // Expected Result: Sue, Bob, Jan, Jon, Tom, Tim
    // Defect(s) Found: No defects found
    public void TestPriorityQueue_2()
    {
        var bob = new PriorityItem("Bob", 2);
        var tim = new PriorityItem("Tim", 1);
        var sue = new PriorityItem("Sue", 3);
        var jan = new PriorityItem("Jan", 2);
        var jon = new PriorityItem("Jon", 2);
        var tom = new PriorityItem("Tom", 2);

        PriorityItem[] expectedResult = [sue, bob, jan, jon, tom, tim];

        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);
        priorityQueue.Enqueue(jan.Value, jan.Priority);
        priorityQueue.Enqueue(jon.Value, jon.Priority);
        priorityQueue.Enqueue(tom.Value, tom.Priority);

        int i = 0;
        int x = 3;
        while (x > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            i++;
            x--;
        }
    
    }

    // Add more test cases as needed below.
}