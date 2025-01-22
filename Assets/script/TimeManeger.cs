using UnityEngine;
using TMPro;  // TextMeshProを使うために必要
using UnityEngine.SceneManagement; // シーン遷移のために追加！

public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining = 60f; // タイマーの初期時間
    public TMP_Text timerText; // TextMeshProのテキストコンポーネント

    void Start()
    {
        if (timerText == null)
            timerText = GetComponent<TMP_Text>(); // もしTextMeshProが設定されてなければ自動で取ってくる
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; // 1フレームごとに減らしていく
        }
        else
        {
            timeRemaining = 0f; // タイマーが0になったら止める
            // タイマーがゼロになったら次のシーンに移動
            if (!SceneManager.GetActiveScene().name.Equals("NextScene")) // すでに遷移してたら重複しないように
            {
                SceneManager.LoadScene("NextScene"); // 次のシーンに遷移（シーン名をここに入力）
            }
        }

        // タイマーを「00:00」形式で表示
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // テキスト更新
    }
}
