using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{

    public int KeyValue = 1;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Collider2D collider = GetComponent<Collider2D>();
            collider.enabled = false;
            
                Destroy(gameObject);
            

        }
    }
 
}
