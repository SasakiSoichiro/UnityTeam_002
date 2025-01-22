using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour
{
    public float mouseSensitivity = 2.0f; // マウス感度
    public float moveSpeed = 5f; // 移動速度
    public Transform playerBody; // プレイヤー本体（カメラが親オブジェクト）

    private float xRotation = 0f; // カメラの上下回転
    private float yRotation = 0f; // カメラの左右回転

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // マウスカーソルを画面中央に固定
        Cursor.visible = false; // マウスカーソルを非表示
    }

    void Update()
    {
        // マウスの動きを取得
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // 上下回転（x軸）を計算
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // 上下回転制限

        // 左右回転（y軸）を計算
        yRotation += mouseX;

        // カメラの回転を適用
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // カメラの上下回転
        playerBody.rotation = Quaternion.Euler(0f, yRotation, 0f); // プレイヤー本体の左右回転

        // プレイヤーの移動処理
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; // 横移動
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime; // 前後移動

        // 移動を反映
        transform.Translate(moveX, 0f, moveZ);
    }
}
