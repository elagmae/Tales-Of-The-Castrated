using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CaisseBehaviour : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D _rb;

    //Bloque les caisses si elles sont l'une contre l'autre
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Caisse")
        {
            _rb.constraints = RigidbodyConstraints2D.FreezePosition | RigidbodyConstraints2D.FreezeRotation ; // Arrête le mouvement du rigidbody en lockant sa position
        }
    }
}
