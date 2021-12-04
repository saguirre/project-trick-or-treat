using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBlock : MonoBehaviour
{
   [SerializeField] private Key.KeyType keyType;

   private void Awake()
    {
        gameObject.SetActive(false);
        if(Singleton.Instance.ContainsKey(keyType)){
            gameObject.SetActive(true);
        }
    }

}
