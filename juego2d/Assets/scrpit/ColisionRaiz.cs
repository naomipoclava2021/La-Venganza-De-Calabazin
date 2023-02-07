using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionRaiz : MonoBehaviour
{
    public int energia = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Raiz"))
        {
            energia += 1;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Enemigo") && energia > 0)
        {
            Destroy(other.gameObject);
            energia--;
        }
    }
}

