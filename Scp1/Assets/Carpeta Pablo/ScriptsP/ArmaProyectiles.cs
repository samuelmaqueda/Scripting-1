using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaProyectiles : MonoBehaviour
{
    public GameObject BalaPrefab;
    public GameObject puntoDisparo;

    public float fuerzaDisparo = 15;
    public float Cadencia = 0.3f;
    float tiempoProxDisparo = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempoProxDisparo -= Time.deltaTime;
        if(tiempoProxDisparo<=0)
        {
            if(Input.GetMouseButtonDown(0))
            {
                GameObject nuevaBala = Instantiate(BalaPrefab, puntoDisparo.transform.position, puntoDisparo.transform.rotation );
                nuevaBala.GetComponent<Rigidbody>().AddForce(puntoDisparo.transform.forward * fuerzaDisparo, ForceMode.Impulse);
                tiempoProxDisparo = Cadencia;
            }
        }
    }
}
