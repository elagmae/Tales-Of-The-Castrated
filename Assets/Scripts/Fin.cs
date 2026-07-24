using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.VisualScripting.Member;

public class Fin : MonoBehaviour
{
    [SerializeField]
    private AudioSource _source;
    [SerializeField]
    private AudioClip _clip;
    [SerializeField]
    private SpriteRenderer spriteRenderer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fin")
        {
            StartCoroutine(PlayFin());
        }
    }

    private IEnumerator PlayFin()
    {
        _source.PlayOneShot(_clip);
        this.spriteRenderer.color = new Color(1f, 1f, 1f, 0f);
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
