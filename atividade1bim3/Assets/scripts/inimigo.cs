
using UnityEngine;

public class Inimigo : Personagem
{
    [SerializeField]
    void Start()
    {
        
    }
    void Update()
    {
        if (getVida() <= 0)
        {
            Destroy(gameObject);
        }
    }
}
