using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    private float countdown = 30f; // カウントダウン開始時間

    void Update()
    {
        // タイマーが終了する前
        if (countdown > 0f)
        {
            countdown -= Time.deltaTime; // 経過時間を減算
            Debug.Log("残り時間: " + countdown.ToString("F2"));
        }
        else
        {
            // タイマーが終了した後の処理
            Debug.Log("タイマー終了!");
        }
    }
}
