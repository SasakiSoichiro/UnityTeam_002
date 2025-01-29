using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // �e��Prefab��p�ӂ���

    public float maxDistance = 50f;  // �ő�˒�
    private Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }
    void Update()
    {


        // ���ˈʒu����̋������v�Z���āA�ő勗���𒴂��������
        if (Vector3.Distance(startPosition, transform.position) > maxDistance)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target")) // �G�ɓ���������
        {
            // �G��|����������
            Destroy(collision.gameObject); // �G����������
        }

        Destroy(gameObject); // �e���g�͏���

        Debug.Log("�Փ˂����I�u�W�F�N�g: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Target"))
        {
            Debug.Log("�^�[�Q�b�g�ɓ�������");
            Destroy(gameObject);  // �e������
        }
    }



}
