using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverCirculo : MonoBehaviour
{
    public float movX, movZ;
    public float speed;
    public bool quiereSaltar = false;
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
    }
    private void FixedUpdate()
    {
        Vector3 nuevaVelocidad = new Vector3(movX * speed, fisicas.velocity.y, movZ * speed);
        fisicas.velocity = nuevaVelocidad;
    }
}
