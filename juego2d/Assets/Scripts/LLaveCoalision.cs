using UnityEngine;

public class LLaveCoalision : MonoBehaviour
{
    public AudioClip sonidollave;
    public ControladorDeMusica controlador1;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemigo")
        {
            controlador1.RetornarSonido(sonidollave);
            Destroy(col.gameObject);
        }
    }
}

