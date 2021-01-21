using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dano : MonoBehaviour
{
    float temporizador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        temporizador += Time.deltaTime;
        if(temporizador>=1)
        {

            Destroy(gameObject);
        }
    }
}
