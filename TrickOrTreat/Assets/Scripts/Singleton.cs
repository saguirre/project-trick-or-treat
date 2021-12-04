using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance {get;private set;}
    public List<Key.KeyType> inv;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    
    }

    public bool ContainsKey(Key.KeyType keyType) {
        return inv.Contains(keyType);
    }
}
