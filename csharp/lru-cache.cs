public class Node {
    public int Key { get; set; } = -1;
    public int Value { get; set; } = -1;
    public Node Previous { get; set; } = null;
    public Node Next { get; set; } = null;

    Node(int key, int value)
    {
        this.key = key;
        this.value = value;
    }
}

public class LRUCache {
    List<int> cache;
    Node back = new Node();
    Node front = new Node();
    Dictionary<int, int> lookupTable = new Dictionary<int, int>();

    public LRUCache(int capacity) {
        if (capacity < 1)
        {
            return;
        }
        else if (capacity > 3000)
        {
            return;
        }
        cache = new List<int>(capacity);
        back.Next = front;
        front.Previous = back;
    }
    
    public int Get(int key) {
        if (cache[key] is not null)
        {
            return cache[key];
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if (cache.Count == capacity)
        {
            cache.Insert(0, value)
        }
        else
        {

        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
