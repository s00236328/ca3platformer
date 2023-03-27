using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerBlock : MonoBehaviour
{
    public GameObject objectToDestroy;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            {
                if (collision.gameObject.CompareTag("Player"))
                {
                    Destroy(objectToDestroy);
                }
            }
        
    }

}
