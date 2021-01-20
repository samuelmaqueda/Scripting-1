using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
	public bool dentro;
	public GameObject enemigo;
	public float contador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (dentro == true)
		{
			contador += Time.deltaTime;
			if (contador >= 3f)
			{
				contador = 0f;
				Instantiate(enemigo, transform.position, transform.rotation);
			}
		}
    }

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "player")
		{
			dentro = true;
		}
		
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "player")
		{
			dentro = false;
		}
	}
}
