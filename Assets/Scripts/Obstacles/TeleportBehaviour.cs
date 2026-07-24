using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject _depart;
    [SerializeField]
    private GameObject _arrivee;
    [SerializeField]
    private AudioSource _source;
    [SerializeField]
    private AudioClip _clip;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == _depart)
        {
            _source.PlayOneShot(_clip);
            this.transform.position = _arrivee.transform.position + Vector3.right;
        }

        if (collision.gameObject == _arrivee)
        {
            _source.PlayOneShot(_clip);
            this.transform.position = _depart.transform.position + Vector3.left;
        }
    }
}
