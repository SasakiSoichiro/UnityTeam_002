using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
   public GameObject Sphere;
   public float speed = 20f; // �e�̃X�s�[�h
   void Start() 
   { // �e�̈ړ�������ݒ�
        Rigidbody rb = Sphere.GetComponent<Rigidbody>(); 
        rb.velocity = transform.forward * speed; 
   } 
   void OnCollisionEnter(Collision collision) 
   { // �^�[�Q�b�g�ɓ���������e������
        if (collision.gameObject.CompareTag("Target")) 
        { 
            Destroy(Sphere); 
        } 
   }
}
