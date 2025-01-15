using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChikadaScript : MonoBehaviour
{
    public GameObject spherePrefab; // �������鋅��Prefab
    public GameObject maincamera; // �J����
    public int numberOfSpheres = 10; // �������鋅�̐�
    public Vector3 center = Vector3.zero; // �����͈͂̒��S
    public float range = 5f; // �����͈͂̔��a

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
            // �����_���Ȉʒu���v�Z
            Vector3 randomPosition = center + Random.insideUnitSphere * range;

            // ���̂𐶐�
            Instantiate(spherePrefab, randomPosition, Quaternion.identity);
        }
    }
}
