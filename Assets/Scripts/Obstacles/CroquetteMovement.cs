using DG.Tweening;
using System.Collections;
using UnityEngine;

public class FloatBehavior : MonoBehaviour
{
    float originalY;

    public float floatStrength = 0.2f;

    void Start()
    {
        this.originalY = this.transform.position.y;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x,
            originalY + ((float)Mathf.Sin(Time.time*2) * floatStrength),
            transform.position.z);
    }
}