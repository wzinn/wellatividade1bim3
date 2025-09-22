using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class bala : MonoBehaviour
{
    [SerializeField] private int dano;

    [SerializeField] private float velocidade;
    
    public void setDano(int dano)
    {
        this.dano = dano;
    }

    
    public int getDano()
    {
        return this.dano; 
    }
    //
    
    public void setVelocidade(int velocidade)
    {
        this.velocidade = velocidade;
    }

    
    public float getVelocidade()
    {
        return this.velocidade; 
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void onCollisionEnter2D(Collision2D other)
    
    {
        int novavida = other.gameObject.GetComponent<bala>().getDano();
        other.gameObject.GetComponent<bala>().setDano(novavida);
    }
  
    //GameObject.setActive(false)
}
