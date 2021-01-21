using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaRaycast : MonoBehaviour
{
    public float Cadencia = 0.3f;
    float tiempoProxDisparo = 0;

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
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 PosicionMouse = Input.mousePosition;
                Camera mainCamera = Camera.main;
                Ray ray = mainCamera.ScreenPointToRay(PosicionMouse);
                RaycastHit hitInfo;
                if(Physics.Raycast(ray, out hitInfo))
                {
                    if (hitInfo.collider.CompareTag("destruible"))
                    {
                        Destroy(hitInfo.collider.gameObject);
                    }
                    else
                    {
                        GameObject newspark = Instantiate(sparkPref);
                        newspark.transform.position = hitInfo.point;
                        GameObject newDano = Instantiate(danoPref);
                    }
                }
            }
        }
    }
}
