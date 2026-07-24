using System.Linq;
using UnityEngine;

public class CroquetteBehaviour : MonoBehaviour
{
    public static int _recolte;

    [SerializeField]
    private Collider2D _fin;
    [SerializeField]
    private AudioSource _source;
    [SerializeField]
    private AudioClip _clip;

    private GameObject[] _foodList;

    private void Start()
    {
        _foodList = GameObject.FindGameObjectsWithTag("Food");
        if (_foodList.Count() == 0)
        {
            _fin.enabled = true;
        }
        else
        {
            _fin.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Food") 
        {
            _source.PlayOneShot(_clip);
            _recolte++;
            Destroy(collision.gameObject);
        }

        if (_recolte == _foodList.Count())
        {
            _fin.enabled = true;
        }
    }
}
