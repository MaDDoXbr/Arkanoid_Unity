using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject Ball;
    public Vector3 kickoffForce;
    private Rigidbody2D rb;


    // Identificadores são sensíveis à caixa: 'inteiro' é diferente de 'Inteiro'
    int inteiro = 1;
    
    // O "f" identifica que o número não é inteiro nem tem precisão dupla (double)
    float numeroFlutuante = 2.1f;
    
    // String é usado para texto, armazena uma sequência de caracteres
    string texto = "Um texto qualquer";
    
    // Boolean é um valor que pode ser apenas verdadeiro (true) ou falso (false)
    bool ligado = false;
    
    
    
    
    
    

    // Start é chamado logo antes do 'update' do primeiro frame (quadro)
    void Start()
    {
        rb = Ball.GetComponent<Rigidbody2D>();
        rb.AddForce(kickoffForce);
    }

    // Update é executado uma vez a cada frame
//    public void Update()
//    {
//        ShowVelocity();

    public bool NumeroPar(int numero)
    {
        if (numero % 2 == 0)
            return true;
        else                  // Desnecessario nesse caso
            return false;
        
        // ou: return numero % 2 == 0;
    }
    
    void Update()    // Event Function nativo da Unity (1x por frame)
    {
        Debug.Log(NumeroPar(268));    // Imprime no console o resultado

        int contador = 1;
        while (contador != 5)
        {
            Debug.Log(contador); // =>   1, 2, 3, 4
            contador++;          // <=>  contador = contador+1;
        }

        for (int i = 1; i <= 5; i++)
        {
            Debug.Log(i);        // =>   1, 2, 3, 4, 5
        }

        string[] nomes = {"Joao", "Jose", "Maria"};
        foreach (string item in nomes)
        {
            Debug.Log(item);
        }
        
        var listaDeNomes = new List<string> {"Joao", "Jose", "Maria"}; 
    }
        




//    }

    private void ShowVelocity() { Debug.Log(rb.velocity); }
}
