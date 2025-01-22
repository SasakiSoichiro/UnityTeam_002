using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour
{
    //public float mouseSensitivity = 500f; // �}�E�X���x
    //public Transform playerBody;         // �J�������Ǐ]����v���C���[�I�u�W�F�N�g
    //private float xRotation = 0f;        // �J�����̏㉺��]�̂��߂̕ϐ�

    //void Start()
    //{
    //    // �J�[�\�������b�N
    //    Cursor.lockState = CursorLockMode.Locked;
    //}

    //void Update()
    //{
    //    // �}�E�X�̈ړ��ʂ��擾
    //    float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
    //    float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

    //    // �㉺��]�i�J�����̂݁j
    //    xRotation -= mouseY;
    //    xRotation = Mathf.Clamp(xRotation, -90f, 90f); // �㉺��]�p�x�𐧌�
    //    transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

    //    // ���E��]�i�v���C���[�S�̂���]�j
    //    playerBody.Rotate(Vector3.up * mouseX);
    //}
    public float mouseSensitivity = 0.0000001f; // �}�E�X�̊��x
    public Transform playerBody; // �v���C���[�̑́i�J�����̐e�I�u�W�F�N�g�j
    public GameObject bulletPrefab; // �e�̃v���n�u
    public Transform shootingPoint; // �e�𔭎˂���ʒu
    private float xRotation = 0f; // �J������X����]
    
    void Update() 
    { // �}�E�X�Ŏ��_����
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
        xRotation -= mouseY; xRotation = Mathf.Clamp(xRotation, -90f, 90f); // �㉺����
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // �J�����̏㉺��]
        playerBody.Rotate(Vector3.up * mouseX); // �v���C���[�̍��E��]// �}�E�X�̍��N���b�N�Œe�𔭎�
        if (Input.GetMouseButtonDown(0)) // ���N���b�N�i0�j
        { 
            //Shoot(); 
        } 
    } 
    //void Shoot() 
    //{ // �e�𔭎�
    //    Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation); 
    //}
}
