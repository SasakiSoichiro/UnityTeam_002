using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // 弾のPrefabを用意しろ
    public GameObject bulletPrefab;
    public Transform gunTransform; // 銃口の位置
    public float bulletSpeed = 20f; // 弾の速さ
    public float maxDistance = 50f;  // 最大射程
    private Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Fire1はデフォルトでマウスの左クリック
        {
            Shoot();
        }

        // 発射位置からの距離を計算して、最大距離を超えたら消す
        if (Vector3.Distance(startPosition, transform.position) > maxDistance)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) // 敵に当たったら
        {
            // 敵を倒す処理だな
            Destroy(collision.gameObject); // 敵を消し去る
        }

        Destroy(gameObject); // 弾自身は消す
    }


    void Shoot()
    {
        // 弾を生成しろ
        GameObject bullet = Instantiate(bulletPrefab, gunTransform.position, gunTransform.rotation);

        // 弾に力を加えるぜ
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(gunTransform.forward * bulletSpeed, ForceMode.VelocityChange);
    }
    void OnBecameInvisible()
    {
        // オレの弾が画面外に出たら、すぐ消す。
        Destroy(gameObject);
    }
}
