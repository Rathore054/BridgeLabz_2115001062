using System;
using System.Collections.Generic;

public class CustomHashMap
{
    private readonly int size = 1000;
    private List<KeyValuePair<int, int>>[] map;

    public CustomHashMap()
    {
        map = new List<KeyValuePair<int, int>>[size];
    }

    private int Hash(int key) => key % size;

    public void Put(int key, int value)
    {
        int index = Hash(key);
        if (map[index] == null)
            map[index] = new List<KeyValuePair<int, int>>();

        for (int i = 0; i < map[index].Count; i++)
        {
            if (map[index][i].Key == key)
            {
                map[index][i] = new KeyValuePair<int, int>(key, value);
                return;
            }
        }
        map[index].Add(new KeyValuePair<int, int>(key, value));
    }

    public int Get(int key)
    {
        int index = Hash(key);
        if (map[index] != null)
        {
            foreach (var pair in map[index])
            {
                if (pair.Key == key) return pair.Value;
            }
        }
        return -1;
    }
}
