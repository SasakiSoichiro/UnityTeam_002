using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChikadaScriptMk : MonoBehaviour
{
    public Camera mainCamera; // メインカメラ
    public GameObject spherePrefab; // 生成する球のPrefab
    public int numberOfSpheres = 10; // 生成する球の数
    public float sphereSize = 1.0f; // 球のサイズ
    public float spawnInterval = 10f; // 生成間隔（秒）

    void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main; // メインカメラを自動取得
        }
        // 10秒ごとに生成を繰り返す
        InvokeRepeating(nameof(SpawnSpheres), 0f, spawnInterval);
        //SpawnSpheres();
    }

    //void SpawnSpheres()
    //{
    //    for (int i = 0; i < numberOfSpheres; i++)
    //    {
    //        // ランダムなViewport座標 (x: 0〜1, y: 0〜1)
    //        float randomX = Random.Range(0f, 1f);
    //        float randomY = Random.Range(0f, 1f);

    //        // Z軸はカメラからの距離を指定
    //        float distanceFromCamera = Random.Range(5f, 10f); // 5〜10ユニットの範囲でランダム

    //        // Viewport座標をワールド座標に変換
    //        Vector3 randomPosition = mainCamera.ViewportToWorldPoint(new Vector3(randomX, randomY, distanceFromCamera));

    //        // 球を生成
    //        GameObject sphere = Instantiate(spherePrefab, randomPosition, Quaternion.identity);

    //        // 球のサイズを設定
    //        sphere.transform.localScale = Vector3.one * sphereSize;
    //    }
    //}
    void SpawnSpheres()
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