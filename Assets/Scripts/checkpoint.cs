using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public Color Color;
    SpriteRenderer spriteRenderer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.green;
        spriteRenderer.flipX = true;
        // if spriteRenderer.color = Color; then the checkpoint goes invisble//
    }



}
