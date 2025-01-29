using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // 弾のPrefabを用意しろ

    public float maxDistance = 50f;  // 最大射程
    private Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }
    void Update()
    {


        // 発射位置からの距離を計算して、最大距離を超えたら消す
        if (Vector3.Distance(startPosition, transform.position) > maxDistance)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target")) // 敵に当たったら
        {
            // 敵を倒す処理だな
            Destroy(collision.gameObject); // 敵を消し去る
        }

        Destroy(gameObject); // 弾自身は消す

        Debug.Log("衝突したオブジェクト: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Target"))
        {
            Debug.Log("ターゲットに当たった");
            Destroy(gameObject);  // 弾を消す
        }
    }



}
