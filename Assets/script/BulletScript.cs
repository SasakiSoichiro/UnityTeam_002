using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // �e��Prefab��p�ӂ���
    public GameObject bulletPrefab;
    public Transform gunTransform; // �e���̈ʒu
    public float bulletSpeed = 20f; // �e�̑���
    public float maxDistance = 50f;  // �ő�˒�
    private Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Fire1�̓f�t�H���g�Ń}�E�X�̍��N���b�N
        {
            Shoot();
        }

        // ���ˈʒu����̋������v�Z���āA�ő勗���𒴂��������
        if (Vector3.Distance(startPosition, transform.position) > maxDistance)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) // �G�ɓ���������
        {
            // �G��|����������
            Destroy(collision.gameObject); // �G����������
        }

        Destroy(gameObject); // �e���g�͏���
    }


    void Shoot()
    {
        // �e�𐶐�����
        GameObject bullet = Instantiate(bulletPrefab, gunTransform.position, gunTransform.rotation);

        // �e�ɗ͂������邺
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(gunTransform.forward * bulletSpeed, ForceMode.VelocityChange);
    }
    void OnBecameInvisible()
    {
        // �I���̒e����ʊO�ɏo����A���������B
        Destroy(gameObject);
    }
}
