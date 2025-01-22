using UnityEngine;
using TMPro;  // TextMeshPro���g�����߂ɕK�v
using UnityEngine.SceneManagement; // �V�[���J�ڂ̂��߂ɒǉ��I

public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining = 60f; // �^�C�}�[�̏�������
    public TMP_Text timerText; // TextMeshPro�̃e�L�X�g�R���|�[�l���g

    void Start()
    {
        if (timerText == null)
            timerText = GetComponent<TMP_Text>(); // ����TextMeshPro���ݒ肳��ĂȂ���Ύ����Ŏ���Ă���
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; // 1�t���[�����ƂɌ��炵�Ă���
        }
        else
        {
            timeRemaining = 0f; // �^�C�}�[��0�ɂȂ�����~�߂�
            // �^�C�}�[���[���ɂȂ����玟�̃V�[���Ɉړ�
            if (!SceneManager.GetActiveScene().name.Equals("NextScene")) // ���łɑJ�ڂ��Ă���d�����Ȃ��悤��
            {
                SceneManager.LoadScene("NextScene"); // ���̃V�[���ɑJ�ځi�V�[�����������ɓ��́j
            }
        }

        // �^�C�}�[���u00:00�v�`���ŕ\��
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // �e�L�X�g�X�V
    }
}
