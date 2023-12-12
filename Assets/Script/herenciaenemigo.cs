using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class herenciaenemigo : MonoBehaviour
{
    protected int speedx;
    public int Direccionx;
    public int Direcciony;
    protected int daño;
    private Rigidbody2D _compRigiDbody2D;
    private void Awake()
    {
        _compRigiDbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        _compRigiDbody2D.velocity = new Vector2(speedx * Direccionx, speedx * Direcciony);
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Muro"))
        {
            if (Direccionx == 1)
            {
                Direccionx = -1;
            }
            else if (Direccionx == -1)
            {
                Direccionx = 1;
            }

        }
        if (collision.gameObject.CompareTag("Techo"))
        {
            if (Direcciony == 1)
            {
                Direcciony = -1;
            }
            else if (Direcciony == -1)
            {
                Direcciony = 1;
            }
        }
    }
   
}
