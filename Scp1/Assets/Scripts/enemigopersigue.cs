using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigopersigue : MonoBehaviour
{
	public float speed = 5f;
	public Vector3 spawnPosition;
	Rigidbody rb;
	public bool activo = true;
	public float contador;
	public float random;
	public float vida = 2f;
	Renderer m_renderer;
	public Vector3 fwd;
	public GameObject player;
	public bool perseguir = false;
	// Start is called before the first frame update
	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}
	void Start()
	{
		m_renderer = GetComponent<Renderer>();
		spawnPosition = new Vector3(Random.insideUnitSphere.x, 0f, Random.insideUnitSphere.z);
		random = Random.Range(3f, 5f);
		fwd = transform.TransformDirection(Vector3.forward);
		player = GameObject.FindGameObjectWithTag("Player");
	}

	// Update is called once per frame
	void Update()
	{
		rb.velocity = spawnPosition * speed;
		contador += Time.deltaTime;
		transform.LookAt(player.transform);

		if (contador >= random)
		{
			random = Random.Range(3f, 5f);
			contador = 0f;
			spawnPosition = new Vector3(Random.insideUnitSphere.x, 0f, Random.insideUnitSphere.z);
		}
	}

	private void FixedUpdate()
	{
		RaycastHit hit;
		
		if (Physics.Raycast(transform.position, fwd, out hit))
		{
			if (hit.collider.gameObject.tag == "Player" && hit.distance <= 20f)
			{
				perseguir = true;
			}
			else
			{
				perseguir = false;
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "bala")
		{
			vida--;
			if (vida <= 0)
			{
				Destroy(gameObject);
			}
			else
			{
				m_renderer.material.color = Color.red;
			}
		}
	}
}
