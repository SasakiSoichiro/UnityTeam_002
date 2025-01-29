using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject Sphere;
    public GameObject Bullet;
    public Transform firePoint;     // �e�����˂����ʒu
    public float speed = 20f; // �e�̃X�s�[�h
    void Start()
    { // �e�̈ړ�������ݒ�
        Rigidbody rb = Bullet.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }
    void Update()
    {
        // �}�E�X���N���b�N�Œe�𔭎�
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    void OnCollisionEnter(Collision collision)
    { // �^�[�Q�b�g�ɓ���������e������
        if (collision.gameObject.CompareTag("Target"))
        {
            Destroy(Sphere);
        }
    }


    void Shoot()
    {
        // �e�𐶐�
        GameObject bullet = Instantiate(Bullet, firePoint.position, firePoint.rotation);

        // Rigidbody�Œe���΂�
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
    }
}
