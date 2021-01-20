using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigotonto : MonoBehaviour
{
	public float speed = 5f;
	public Vector3 spawnPosition;
	Rigidbody rb;
	public bool activo = true;
	public float contador;
	// Start is called before the first frame update

	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}
	void Start()
    {
		spawnPosition = new Vector3(Random.insideUnitSphere.x, 0f, Random.insideUnitSphere.z);
	}

    // Update is called once per frame
    void Update()
    {
		rb.velocity = spawnPosition;
		contador += Time.deltaTime;

		Random.Range(3f, 5f);

		if (activo == true)
		{
			
		}
	}
}
