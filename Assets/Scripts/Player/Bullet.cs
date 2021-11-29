using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private GameObject hitEffect;
    [SerializeField]
    private float timeToClose;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject gameObject = Instantiate(this.hitEffect, this.transform.position, Quaternion.identity);
        Destroy(gameObject, timeToClose);
        Destroy(this.gameObject);
    }
}
