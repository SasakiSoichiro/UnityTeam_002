using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    private float countdown = 30f; // �J�E���g�_�E���J�n����

    void Update()
    {
        // �^�C�}�[���I������O
        if (countdown > 0f)
        {
            countdown -= Time.deltaTime; // �o�ߎ��Ԃ����Z
            Debug.Log("�c�莞��: " + countdown.ToString("F2"));
        }
        else
        {
            // �^�C�}�[���I��������̏���
            Debug.Log("�^�C�}�[�I��!");
        }
    }
}
