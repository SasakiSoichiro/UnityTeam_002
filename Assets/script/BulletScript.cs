using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject Sphere;
    public GameObject Bullet;
    public Transform firePoint;     // 弾が発射される位置
    public float speed = 20f; // 弾のスピード
    void Start()
    { // 弾の移動方向を設定
        Rigidbody rb = Bullet.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }
    void Update()
    {
        // マウス左クリックで弾を発射
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    void OnCollisionEnter(Collision collision)
    { // ターゲットに当たったら弾を消す
        if (collision.gameObject.CompareTag("Target"))
        {
            Destroy(Sphere);
        }
    }


    void Shoot()
    {
        // 弾を生成
        GameObject bullet = Instantiate(Bullet, firePoint.position, firePoint.rotation);

        // Rigidbodyで弾を飛ばす
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
    }
}
