using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChikadaScriptMk1 : MonoBehaviour
{
    public GameObject spherePrefab; // 生成する球のプレハブ
    public float spawnInterval = 10f; // 生成間隔（秒）

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
        if (mainCamera == null)
        {
            Debug.LogError("Main Cameraが見つかりません。");
            return;
        }

        // 10秒ごとに生成を繰り返す
        InvokeRepeating(nameof(SpawnSphere), 0f, spawnInterval);
    }

    void SpawnSphere()
    {
        if (spherePrefab == null || mainCamera == null) return;

        // カメラのスクリーン範囲からワールド座標を計算
        Vector3 randomScreenPosition = new Vector3(
            Random.Range(0, Screen.width),
            Random.Range(0, Screen.height),
            mainCamera.nearClipPlane
        );

        Vector3 spawnPosition = mainCamera.ScreenToWorldPoint(randomScreenPosition);

        // 球を生成
        Instantiate(spherePrefab, spawnPosition, Quaternion.identity);
    }
}
