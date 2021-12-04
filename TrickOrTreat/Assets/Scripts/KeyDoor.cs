using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
   [SerializeField] private Key.KeyType keyType;

   public Key.KeyType GetKeyType() {
       return keyType;
   }

   public void OpenDoor() {
       gameObject.SetActive(false);
   }

   private void Awake()
    {
        if(Singleton.Instance){
            if(Singleton.Instance.ContainsKey(keyType)){
                gameObject.SetActive(false);
            }
        }
    }

}
