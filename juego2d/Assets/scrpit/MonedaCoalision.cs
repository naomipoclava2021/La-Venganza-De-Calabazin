using UnityEngine;

public class MonedaCoalision : MonoBehaviour
{

    public int puntos = 0;
    public AudioClip sonidoMoneda;
    public ControladorDeMusica controlador;
    public Puntos score;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Moneda")
        {
            puntos += 10;
            score.ActualizarPuntaje(puntos);
            controlador.RetornarSonido(sonidoMoneda);
            Destroy(col.gameObject);
        }
    }
}

