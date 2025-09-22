using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 5f;  // Define a velocidade do jogador

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Movimento para a esquerda (A)
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(velocidade * Time.deltaTime, 0, 0);
        }

        // Movimento para a direita (D)
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(velocidade * Time.deltaTime, 0, 0);
        }

        // Movimento para frente (W)
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, velocidade * Time.deltaTime);
        }

        // Movimento para trás (S)
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, 0, velocidade * Time.deltaTime);
        }
    }
}