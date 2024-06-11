using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.SceneManagement;

public class BarrierDirector : MonoBehaviour
{
    // �o���A�̑ϋv�l
    public int barrierHp = 10000;
    // ��x�_���[�W��H��������莞�ԃ_���[�W��H���Ȃ��悤�ɂ���
    private float damageCoolTime = 0f;
    // �_���[�W��
    private int damage = 1;

    bool enemyHit = false;

    GameObject Enemy = null;

    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.Find("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        // �ϋv�l���Ȃ��Ȃ�����
        if (barrierHp <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOverScene");
        }
    }

    private void FixedUpdate()
    {
        
    }

    // Enemy�ƐڐG������
    void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.CompareTag("Enemy"))
        {
            barrierHp -= 1;
            Debug.Log("�_���[�W�I");
        }
    }
}
