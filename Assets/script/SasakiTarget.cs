using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SasakiTarget : MonoBehaviour
{
    public int points = 10; // 撃ったときにもらえるスコア
    public ScoreManager scoreManager; // ScoreManagerの参照

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 弾が当たったときに呼ばれるメソッド
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) // 弾が当たったか確認
        {
            scoreManager.IncreaseScore(points); // スコアを増加
            Destroy(gameObject); // 的を消す
        }
    }

}
