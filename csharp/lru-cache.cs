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
    int capacity = -1;
    int count = 0;
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
        this.capacity = capacity;
        back.Next = front;
        front.Previous = back;
    }

    public int Get(int key) {
        // if key in table, get Node, get value, move to front
        // else, return -1
    }

    public void Put(int key, int value) {
        // if count = capacity, evict, add
        // else, count++, add
    }

    private void Remove()
    {

    }

    private void Add()
    {

    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
