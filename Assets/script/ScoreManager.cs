using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // TextMesh Pro UI�R���|�[�l���g
    private int score = 0; // �X�R�A�̏����l

    // Start is called before the first frame update
    void Start()
    {
        //������Ȃ������ꍇ�����Ō�����
        if (scoreText == null)
        {
            scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        }

        // �Q�[���J�n���ɃX�R�A�\�����X�V
        UpdateScoreDisplay();

    }

    // Update is called once per frame
    void Update()
    {
    }

    // �X�R�A�𑝉������郁�\�b�h
    public void IncreaseScore(int points)
    {
        score += points;
        UpdateScoreDisplay();
    }

    // �X�R�A�̕\�����X�V���郁�\�b�h
    private void UpdateScoreDisplay()
    {
        // �X�R�A�e�L�X�g���X�V
        scoreText.text = "Score: " + score.ToString();
    }

}
