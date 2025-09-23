
using UnityEngine;

public class Arma : MonoBehaviour
{
    public Transform saidadetiro;

    public GameObject bala;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            GameObject  b =Instantiate(this.bala.gameObject,saidadetiro.position,saidadetiro.rotation) as GameObject;
        }


    }
}