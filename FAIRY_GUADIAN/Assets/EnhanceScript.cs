using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnhanceScript : MonoBehaviour
{
    PlayerController pAttack;

    PlayerController pSpeed;

    ExpBarScript Enhance;

    BarrierDirector Hp;

    Enemy1 eSpeed1;
    Enemy2 eSpeed2;
    Enemy3 eSpeed3;
    Enemy4 eSpeed4;

    float attackTemp;
    float speedTemp;
    float speedTemp2;

    public bool shot;

    public bool spawn;

    public bool barrierDamage;

    // Start is called before the first frame update
    void Start()
    {
        pAttack = GameObject.Find("player").GetComponent<PlayerController>();

        pSpeed = GameObject.Find("player").GetComponent<PlayerController>();

        Enhance = GameObject.Find("exp").GetComponent<ExpBarScript>();

        Hp = GameObject.Find("barrier").GetComponent<BarrierDirector>();

        eSpeed1 = GameObject.Find("Enemy1").GetComponent<Enemy1>();
        eSpeed2 = GameObject.Find("Enemy2").GetComponent<Enemy2>();
        eSpeed3 = GameObject.Find("Enemy3").GetComponent<Enemy3>();
        eSpeed4 = GameObject.Find("Enemy4").GetComponent<Enemy4>();

        attackTemp = pAttack.strength;
        speedTemp = pSpeed.speed;
        speedTemp2 = pSpeed.AddSpeed;

        shot = true;

        spawn = true;

        barrierDamage = true;
    }

    // Update is called once per frame
    void Update()
    {
        // ���V�t�g��������Ă��
        if(Input.GetKey(KeyCode.LeftShift))
        {
            // �G�̓������~�܂�
            eSpeed1.speed = 0.0f;
            eSpeed2.speed = 0.0f;
            eSpeed3.speed = 0.0f;
            eSpeed4.speed = 0.0f;
            // ������ʂ�\��
            transform.position = new Vector3(0, 0, 0);
            // �v���C���[�̍U���͂�0�ɂ���
            pAttack.strength *= 0.0f;
            // �v���C���[�̓������~�߂�
            pSpeed.speed = 0.0f;
            pSpeed.AddSpeed = 0.0f;
            
            shot = false;

            spawn = false;

            barrierDamage = false;

            // A�������ꂽ��
            if (Input.GetKeyDown(KeyCode.A) && Enhance.enhance > 0)
            {
                // �U���͂�0.5�グ��
                attackTemp += 0.5f;
                Enhance.enhance -= 1;
            }

            // S�������ꂽ��
            if (Input.GetKeyDown(KeyCode.S) && Enhance.enhance > 0)
            {
                // �o���A�̑ϋv�l��3��
                Hp.barrierHp += 3;
                Enhance.enhance -= 1;
            }

            // D�������ꂽ��
            if (Input.GetKeyDown(KeyCode.D) && Enhance.enhance > 0)
            {
                // �X�s�[�h���グ��
                speedTemp += 0.002f;
                speedTemp2 += 0.12f;
                Enhance.enhance -= 1;
            }
        }

        // ���V�t�g�������ꂽ��
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            // ������ʂ����
            transform.position = new Vector3(0, 30, 0);
            // �G�̓������ĊJ����
            eSpeed1.speed += 0.005f;
            eSpeed2.speed += 0.005f;
            eSpeed3.speed += 0.005f;
            eSpeed4.speed += 0.005f;
            // �v���C���[�̍U���͂����ɖ߂�
            pAttack.strength = attackTemp;
            // �v���C���[�̓������ĊJ����
            pSpeed.speed = speedTemp;
            pSpeed.AddSpeed = speedTemp2;

            shot = true;

            spawn = true;

            barrierDamage = true;

            Debug.Log(Hp.barrierHp);
        }
    }
}
