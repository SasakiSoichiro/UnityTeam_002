using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SasakiTarget : MonoBehaviour
{
    public int points = 10; // �������Ƃ��ɂ��炦��X�R�A
    public ScoreManager scoreManager; // ScoreManager�̎Q��

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // �e�����������Ƃ��ɌĂ΂�郁�\�b�h
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) // �e�������������m�F
        {
            scoreManager.IncreaseScore(points); // �X�R�A�𑝉�
            Destroy(gameObject); // �I������
        }
    }

}
