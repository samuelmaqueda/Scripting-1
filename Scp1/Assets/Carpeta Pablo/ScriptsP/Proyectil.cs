using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{

    public GameObject sparkPref;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 5);   
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "destruible")
        {
            Destroy(collision.gameObject);
        }

        GameObject newspark = Instantiate(sparkPref);
        ContactPoint puntoImpacto = collision.contacts[0];
        newspark.transform.position = puntoImpacto.point;

        Destroy(this.gameObject);
    }
}
