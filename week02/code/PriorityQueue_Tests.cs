using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: add items with different priorities and dequeue them to check if the highest priority item is returned first
    // Expected Result: the item with the highest priority is returned first
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Item1", 1);
        priorityQueue.Enqueue("Item2", 10);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Item1", result);
    }

    [TestMethod]
    // Scenario: add items with the same priority and dequeue them to check if they are returned in FIFO order
    // Expected Result: items with the same priority are returned in FIFO order

    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Item1", 9);
        priorityQueue.Enqueue("Item2", 9);
        priorityQueue.Enqueue("Item3", 9);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Item2", result);
        
    }

    [TestMethod]
    // Scenario: add items with different priorities and dequeue them to check if the highest priority item is returned first
    // Expected Result: the item with the highest priority is returned first
    public void TestPriorityQueue_5()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Item1", 1);
        priorityQueue.Enqueue("Item2", 100);
        priorityQueue.Enqueue("Item3", 10);

        Assert.AreEqual("Item2", priorityQueue.Dequeue());
        Assert.AreEqual("Item3", priorityQueue.Dequeue());
        Assert.AreEqual("Item1", priorityQueue.Dequeue());
      
    }

    [TestMethod]
    // Scenario: add items with the same priority and dequeue them to check if they are returned in FIFO order
    // Expected Result: items with the same priority are returned in FIFO order
    public void TestPriorityQueue_6()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
        Assert.AreEqual("The queue is empty.", exception.Message);
    }

}