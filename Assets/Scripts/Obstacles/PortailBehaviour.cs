using System.Collections;
using UnityEngine;

public class PortailBehaviour : MonoBehaviour
{
    [SerializeField]
    private int _speed = 2;
    [SerializeField]
    private Rigidbody2D _rb;
    [SerializeField]
    private Sprite _interrupteurPressed;
    [SerializeField]
    private Sprite _interrupteurNotPressed;
    [SerializeField]
    private SpriteRenderer _spriteRenderer;
    [SerializeField]
    private AudioSource _audioSource;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        _audioSource.Play();
        this._spriteRenderer.sprite = _interrupteurPressed;
        StartCoroutine(PortailActivation());
    }

    private IEnumerator PortailActivation()
    {
        var defaultPos = _rb.transform.position.y;
        while (_rb.transform.position.y < defaultPos + 3)
        {
            _rb.MovePosition(_rb.transform.position + Vector3.up * _speed * Time.fixedDeltaTime);
            yield return new WaitForFixedUpdate();
        }

        yield return new WaitForSeconds(4.0f);
        this._spriteRenderer.sprite = _interrupteurNotPressed;

        while (_rb.transform.position.y >= defaultPos)
        {
            _rb.MovePosition(_rb.transform.position + Vector3.down * _speed * Time.fixedDeltaTime);
            yield return new WaitForFixedUpdate();
        }

    }
}
