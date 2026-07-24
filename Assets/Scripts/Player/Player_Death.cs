using System.Collections;
using UnityEngine;

public class Player_Death : MonoBehaviour
{

    [SerializeField]
    private LoadScene reload;
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    [SerializeField]
    private PlayerMovement _playerMove;
    [SerializeField]
    private AudioClip _playerFall;
    [SerializeField]
    private AudioClip _playerDrown;
    [SerializeField]
    private AudioSource _playerSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            StartCoroutine("Drown");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Void")
        {
            StartCoroutine("Fall");
        }
    }

    private IEnumerator Drown()
    {
        _playerSound.PlayOneShot(_playerDrown);
        this.spriteRenderer.color = new Color(1f, 1f, 1f, 0f);
        _playerMove.enabled = false;
        yield return new WaitForSeconds(2.0f);
        reload.ChangeScene("DeathScene");
    }

    private IEnumerator Fall()
    {
        _playerSound.PlayOneShot(_playerFall);
        yield return new WaitForSeconds(3.5f);
        this.spriteRenderer.color = new Color(1f, 1f, 1f, 0f);
        _playerMove.enabled = false;
        reload.ChangeScene("DeathScene");
    }
}