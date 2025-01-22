using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour
{
    //public float mouseSensitivity = 500f; // マウス感度
    //public Transform playerBody;         // カメラが追従するプレイヤーオブジェクト
    //private float xRotation = 0f;        // カメラの上下回転のための変数

    //void Start()
    //{
    //    // カーソルをロック
    //    Cursor.lockState = CursorLockMode.Locked;
    //}

    //void Update()
    //{
    //    // マウスの移動量を取得
    //    float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
    //    float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

    //    // 上下回転（カメラのみ）
    //    xRotation -= mouseY;
    //    xRotation = Mathf.Clamp(xRotation, -90f, 90f); // 上下回転角度を制限
    //    transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

    //    // 左右回転（プレイヤー全体を回転）
    //    playerBody.Rotate(Vector3.up * mouseX);
    //}
    public float mouseSensitivity = 0.0000001f; // マウスの感度
    public Transform playerBody; // プレイヤーの体（カメラの親オブジェクト）
    public GameObject bulletPrefab; // 弾のプレハブ
    public Transform shootingPoint; // 弾を発射する位置
    private float xRotation = 0f; // カメラのX軸回転
    
    void Update() 
    { // マウスで視点操作
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
        xRotation -= mouseY; xRotation = Mathf.Clamp(xRotation, -90f, 90f); // 上下制限
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // カメラの上下回転
        playerBody.Rotate(Vector3.up * mouseX); // プレイヤーの左右回転// マウスの左クリックで弾を発射
        if (Input.GetMouseButtonDown(0)) // 左クリック（0）
        { 
            //Shoot(); 
        } 
    } 
    //void Shoot() 
    //{ // 弾を発射
    //    Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation); 
    //}
}
