using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float velocidad = 10f;
    public float fuerzaSalto = 10f;
    public int numeroMaximoSaltos = 2;
    public float tiempoEspera = 2f;
    private int saltosActuales;
    private float tiempoDesdeUltimoSalto;

    private Rigidbody2D rb;
    private Animator animator;

    void Start()

    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        Vector2 movimiento = new Vector2(movimientoHorizontal * velocidad, rb.velocity.y);
        rb.velocity = movimiento;

        tiempoDesdeUltimoSalto += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && saltosActuales < numeroMaximoSaltos)
        {
            animator.SetBool("isJump", true);
            saltosActuales++;
            tiempoDesdeUltimoSalto = 0;
            rb.velocity = Vector2.up * fuerzaSalto;
        }
        else
        {
            animator.SetBool("isJump", false);

        }

        if (tiempoDesdeUltimoSalto >= tiempoEspera)
        {
            saltosActuales = 0;
        }
    }
}
