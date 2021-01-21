using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarArma : MonoBehaviour
{
    public GameObject Arma1;
    public GameObject Arma2;
    public GameObject Arma3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Arma1.SetActive(true);
            Arma2.SetActive(false);
            Arma3.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Arma1.SetActive(false);
            Arma2.SetActive(true);
            Arma3.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Arma1.SetActive(false);
            Arma2.SetActive(false);
            Arma3.SetActive(true);
        }
    }
}
