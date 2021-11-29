using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private Transform firePoint;
    private GameObject bulletPrefab;
    private float bulletForce;

    public Shoot(Transform firePoint, GameObject bulletPrefab, float bulletForce)
    {
        this.firePoint = firePoint;
        this.bulletPrefab = bulletPrefab;
        this.bulletForce = bulletForce;
    }

    public void clickMouse()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }

    private void shoot()
    {
        GameObject gameObject = Instantiate(this.bulletPrefab, this.firePoint.position, this.firePoint.rotation);

        Rigidbody2D rigidbody = gameObject.GetComponent<Rigidbody2D>();

        rigidbody.AddForce(this.firePoint.up * this.bulletForce, ForceMode2D.Impulse);
    }
}
