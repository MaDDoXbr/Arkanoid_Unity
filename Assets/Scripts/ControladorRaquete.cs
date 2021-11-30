using UnityEngine;

public class ControladorRaquete : MonoBehaviour
{
    public float Velocidade;
    public Vector3 PosicaoInicial;

    void Start()
    {
        PosicaoInicial = transform.position;
    }

    void FixedUpdate()
    {
        var hor = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody>().velocity = new Vector3(hor * Velocidade, 0f, 0f);
    }

    public void PerdeuVida()
    {
        transform.position = PosicaoInicial;
    }
}
