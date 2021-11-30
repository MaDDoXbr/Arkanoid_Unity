using UnityEngine;
using UnityEngine.UI;

public class ControladorBola : MonoBehaviour
{
    public Vector3 ChuteInicial;
    public Vector3 PosicaoInicial;

    public ControladorRaquete Raquete;
    public Text TextPlacar, TextVidas;
    public int Placar;
    public int Vidas = 3;
    
    // O "Start" é chamado logo antes do desenho do primeiro quadro do jogo (frame)
    void Start()
    {
        PosicaoInicial = transform.position;
        GetComponent<Rigidbody>().velocity = ChuteInicial;
        TextPlacar.text = "0";
        TextVidas.text = "Vidas: 3";
        Placar = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("saida"))
            PerdeuVida();
    }

    void OnCollisionEnter(Collision other)
    {
        var bloco = other.gameObject.GetComponent<Bloco>();
        if (bloco)
        {
            Placar = Placar + bloco.Valor;
            TextPlacar.text = Placar + "";
            Destroy(other.gameObject);            
        }
    }

    void OnCollisionExit(Collision other)
    {
        var vel = GetComponent<Rigidbody>().velocity;
        var velx = Mathf.Sign(vel.x) * Mathf.Max(Mathf.Abs(vel.x), ChuteInicial.x);
        var vely = Mathf.Sign(vel.y) * Mathf.Max(Mathf.Abs(vel.y), ChuteInicial.y);
        GetComponent<Rigidbody>().velocity = new Vector3(velx, vely);
    }

    void PerdeuVida()
    {
        Vidas--;
        TextVidas.text = "Vidas: " + Vidas;
        if (Vidas > 0)
        {
            transform.position = PosicaoInicial;
            GetComponent<Rigidbody>().velocity = ChuteInicial;
            Raquete.PerdeuVida();
        }
        else
        {
            Destroy(gameObject);
            Destroy(Raquete.gameObject);
        }
    }

}
