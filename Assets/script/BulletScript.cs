using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
   public GameObject Sphere;
   public float speed = 20f; // 弾のスピード
   void Start() 
   { // 弾の移動方向を設定
        Rigidbody rb = Sphere.GetComponent<Rigidbody>(); 
        rb.velocity = transform.forward * speed; 
   } 
   void OnCollisionEnter(Collision collision) 
   { // ターゲットに当たったら弾を消す
        if (collision.gameObject.CompareTag("Target")) 
        { 
            Destroy(Sphere); 
        } 
   }
}
