using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class BarrierDirector : MonoBehaviour
{
    // �o���A�̑ϋv�l
    private int barrierHp = 100;
    // ��x�_���[�W��H��������莞�ԃ_���[�W��H���Ȃ��悤�ɂ���
    private float damageCoolTime = 0f;
    // �_���[�W��
    private int damage = 1;

    GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.Find("enemy");
    }

    // Update is called once per frame
    void Update()
    {
        // �ϋv�l���Ȃ��Ȃ�����
        if (barrierHp <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Enemy�ƐڐG������
    void OnTriggerEnter2D(Collider2D Other)
    {
        if(Other.CompareTag("Enemy"))
        {
            Debug.Log("�_���[�W�I");
            barrierHp -= damage;
        }
    }
}
