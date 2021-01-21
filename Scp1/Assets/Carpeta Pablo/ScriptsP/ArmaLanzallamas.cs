using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaLanzallamas : MonoBehaviour
{
    public float Cadencia = 0;
    float tiempoProxDisparo = 0;

    public GameObject puntoDisparo;
    public GameObject sparkPref;
    public GameObject danoPref;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempoProxDisparo -= Time.deltaTime;
        if (tiempoProxDisparo <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                GameObject nuevofuego = Instantiate(sparkPref, puntoDisparo.transform.position, puntoDisparo.transform.rotation);
                GameObject nuevodano = Instantiate(danoPref, puntoDisparo.transform.position, puntoDisparo.transform.rotation);
                tiempoProxDisparo = Cadencia;
            }
            
        }
    }
}
