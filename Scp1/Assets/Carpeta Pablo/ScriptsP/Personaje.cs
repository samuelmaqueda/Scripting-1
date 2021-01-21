using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public Rigidbody jugadorRB;

    bool suelo = true;

    public float life = 100;
    public float danoEnemigo = 20;
    public float temporizadordano;
    public float fuerzaSalto = 6;
    public float gravedad;
    float temporizador;
    public float velocidad = 5;
    
    public float velocidadCorriendo = 1.5f;
    
    Vector3 Movimiento;

    // Start is called before the first frame update
    void Start()
    {
        jugadorRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
            
            if (Input.GetKeyDown(KeyCode.Space)&& suelo == true)
            {
                jugadorRB.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
                suelo = false;
            }
            if (temporizadordano <= 2)
            {
                temporizadordano += Time.deltaTime;
            }


    }

    void FixedUpdate()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Vector3 moveDirection = transform.forward * vInput + transform.right * hInput;
            moveDirection.Normalize();
            jugadorRB.velocity = moveDirection * velocidad + transform.up * jugadorRB.velocity.y;
        }
        else 
        {
            Vector3 moveDirection = transform.forward * vInput + transform.right * hInput;
            moveDirection.Normalize();
            jugadorRB.velocity = moveDirection * velocidad + transform.up * jugadorRB.velocity.y;

        }

        if(hInput==0&& vInput==0)
        {
            jugadorRB.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
        }
        else
        {
            jugadorRB.constraints = RigidbodyConstraints.FreezeRotation;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="suelo")
        {
            suelo = true;
        }
        if (collision.gameObject.tag=="enemigo" && temporizadordano==2)
        {
            life = life - danoEnemigo;
            if(life<=0)
            {
                Destroy(gameObject);
            }
        }
    }

}
