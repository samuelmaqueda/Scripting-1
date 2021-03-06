﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigotonto : MonoBehaviour
{
	public float speed = 5f;
	public Vector3 spawnPosition;
	Rigidbody rb;
	public bool activo = true;
	public float contador;
	public float random;
	public float vida = 2f;
	Renderer m_renderer;
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
	}

    // Update is called once per frame
    void Update()
    {
		rb.velocity = spawnPosition * speed;
		contador += Time.deltaTime;

		if (contador >= random)
		{
			random = Random.Range(3f, 5f);
			contador = 0f;
			spawnPosition = new Vector3(Random.insideUnitSphere.x, 0f, Random.insideUnitSphere.z);
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
