using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : MonoBehaviour
{
    public int keysNeeded;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player Player = collision.gameObject.GetComponent<Player>();
            
            
            if (keysNeeded < Player.Keys)
            {
                Destroy(gameObject);
            }
        }

    }
}
