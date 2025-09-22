using UnityEngine;

public class inimigo : MonoBehaviour
{

    [SerializeField]private int vida;
    [SerializeField]private int energia;
    [SerializeField]private float velocidade;

    public void setvida(int vida)
    {
        this.vida = vida;
    }



    public int getvida()
    {
        return vida;
    }
    //
    
    public void setenergia(int energia)
    {
        this.energia = energia;
    }



    public int getenergia()
    {
        return energia;
    }
    
    //
    
    public void setvelocidade(int energia)
    {
        this.velocidade = energia;
    }
    
    
    public int getvelocidade()
    {
        return vida;
    }


}