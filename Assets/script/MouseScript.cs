using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour
{
    public float mouseSensitivity = 2.0f; // �}�E�X���x
    public float moveSpeed = 5f; // �ړ����x
    public Transform playerBody; // �v���C���[�{�́i�J�������e�I�u�W�F�N�g�j

    private float xRotation = 0f; // �J�����̏㉺��]
    private float yRotation = 0f; // �J�����̍��E��]

    public GameObject bulletPrefab;
    public Transform gunTransform; // �e���̈ʒu
    public float bulletSpeed = 20f; // �e�̑���

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // �}�E�X�J�[�\������ʒ����ɌŒ�
        Cursor.visible = false; // �}�E�X�J�[�\�����\��
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Fire1�̓f�t�H���g�Ń}�E�X�̍��N���b�N
        {
            Shoot();
        }
        // �}�E�X�̓������擾
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // �㉺��]�ix���j���v�Z
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // �㉺��]����

        // ���E��]�iy���j���v�Z
        yRotation += mouseX;

        // �J�����̉�]��K�p
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f); // �J�����̏㉺��]
        //playerBody.rotation = Quaternion.Euler(0f, yRotation, 0f); // �v���C���[�{�̂̍��E��]

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
