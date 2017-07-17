using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D colision)
    {
        print("Colision!");
    }
    void OnTriggerEnter2D(Collider2D colider) {
        print("Triggered!");
    }

}
