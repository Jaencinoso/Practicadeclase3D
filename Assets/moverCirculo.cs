using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverCirculo : MonoBehaviour
{
    public float movX, movZ;
    public float speed;
    public bool quiereSaltar = false;
    public bool estaSuelo = false;
    Rigidbody fisicas;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
        fisicas = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump"))
        {
            quiereSaltar = true;
        }
    }
    private void FixedUpdate()
    {
        Vector3 nuevaVelocidad = new Vector3(movX * speed, fisicas.velocity.y, movZ * speed);
        fisicas.velocity = nuevaVelocidad;

        if (quiereSaltar && estaSuelo)
        {
            fisicas.AddForce(Vector3.up * 10, ForceMode.Impulse);
            quiereSaltar = false;
            estaSuelo = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            estaSuelo |= true;
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Monedas")
        {
            Destroy(collision.gameObject);
        }
    }
}
