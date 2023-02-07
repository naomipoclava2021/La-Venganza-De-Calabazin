using UnityEngine;

public class Raizmusica : MonoBehaviour
{
    public AudioClip sonidoraiz;
    public ControladorDeMusica controlador;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Raiz")
        {
            controlador.RetornarSonido(sonidoraiz);
            Destroy(col.gameObject);
        }
    }
}

