using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // TextMesh Pro UIコンポーネント
    private int score = 0; // スコアの初期値
    private int points = 10; // 撃ったときにもらえるスコア

    // Start is called before the first frame update
    void Start()
    {
        //見つからなかった場合自動で見つける
        if (scoreText == null)
        {
            scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        }

        // ゲーム開始時にスコア表示を更新
        UpdateScoreDisplay();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target")) // 弾が当たったか確認
        {
            IncreaseScore(points); // スコアを増加
            Destroy(gameObject); // 的を消す
        }
    }

    // スコアを増加させるメソッド
    public void IncreaseScore(int points)
    {
        score += points;
        UpdateScoreDisplay();
    }

    // スコアの表示を更新するメソッド
    private void UpdateScoreDisplay()
    {
        // スコアテキストを更新
        scoreText.text = "Score: " + score.ToString();
    }

}
