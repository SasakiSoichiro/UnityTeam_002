using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChikadaScript : MonoBehaviour
{
    public GameObject spherePrefab; // 生成する球のPrefab
    public GameObject maincamera; // カメラ
    public int numberOfSpheres = 10; // 生成する球の数
    public Vector3 center = Vector3.zero; // 生成範囲の中心
    public float range = 5f; // 生成範囲の半径

    void Start()
    {
        if (maincamera == null)
        {
            SpawnSpheres();
        }
    }

    void SpawnSpheres()
    {
        for (int i = 0; i < numberOfSpheres; i++)
        {
            // ランダムな位置を計算
            Vector3 randomPosition = center + Random.insideUnitSphere * range;

            // 球体を生成
            Instantiate(spherePrefab, randomPosition, Quaternion.identity);
        }
    }
}
