using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class BarrierDirector : MonoBehaviour
{
    // �o���A�̑ϋv�l
    private int hp = 15;
    // ��x�_���[�W��H��������莞�ԃ_���[�W��H���Ȃ��悤�ɂ���
    private float damageCoolTime = 0f;
    // �_���[�W��
    private int damage = 1;

    bool enemyHit = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        // �ϋv�l���Ȃ��Ȃ�����
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Damage()
    {
        hp--;
    }
}
