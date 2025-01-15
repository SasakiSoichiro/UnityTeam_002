using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChikadaScriptMk1 : MonoBehaviour
{
    public GameObject spherePrefab; // �������鋅�̃v���n�u
    public float spawnInterval = 10f; // �����Ԋu�i�b�j

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
        if (mainCamera == null)
        {
            Debug.LogError("Main Camera��������܂���B");
            return;
        }

        // 10�b���Ƃɐ������J��Ԃ�
        InvokeRepeating(nameof(SpawnSphere), 0f, spawnInterval);
    }

    void SpawnSphere()
    {
        if (spherePrefab == null || mainCamera == null) return;

        // �J�����̃X�N���[���͈͂��烏�[���h���W���v�Z
        Vector3 randomScreenPosition = new Vector3(
            Random.Range(0, Screen.width),
            Random.Range(0, Screen.height),
            mainCamera.nearClipPlane
        );

        Vector3 spawnPosition = mainCamera.ScreenToWorldPoint(randomScreenPosition);

        // ���𐶐�
        Instantiate(spherePrefab, spawnPosition, Quaternion.identity);
    }
}
