public class LRUCache {
    int[] cache;

    public LRUCache(int capacity) {
        if (capacity < 1)
        {
            return;
        }
        else if (capacity > 3000)
        {
            return;
        }
        cache = new int[capacity];
    }
    
    public int Get(int key) {
        if (cache[key] is not null)
        {
            return cache[key];
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if (cache[key] < 0)
        {
            cache[key] = value;
        }
        else
        {
            cache[key] = value;
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
