using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    #region variables
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private Rigidbody2D rigidbody;
    [SerializeField]
    private Camera camera;
    [SerializeField]
    private Transform firePoint;
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private float bulletForce;
    #endregion

    #region classesComponent
    private Controller controller;
    private Shoot shoot;
    #endregion

    void Start()
    {
        this.controller = new Controller(this.rigidbody,this.moveSpeed, this.camera);
        this.shoot = new Shoot(this.firePoint, this.bulletPrefab, this.bulletForce);        
    }

    void Update()
    {
        controller.setMovement();
        this.shoot.clickMouse();
    }

    private void FixedUpdate()
    {
        controller.move();
    }
}
