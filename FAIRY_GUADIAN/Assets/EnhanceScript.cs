using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnhanceScript : MonoBehaviour
{
    //PlayerController pAttack;

    PlayerController pSpeed;

    //ExpBarScript enhance;

    //Testenemy eSpeed;
    Enemy1 eSpeed1;
    //Enemy1 eSpeed1Clone;
    //Enemy2 eSpeed2;
    //Enemy2 eSpeed2Clone;
    Enemy3 eSpeed3;
    //Enemy3 eSpeed3Clone;
    Enemy4 eSpeed4;
    //Enemy4 eSpeed4Clone;

    //float attackTemp;
    float speedTemp;
    float speedTemp2;

    // Start is called before the first frame update
    void Start()
    {
        //pAttack = GameObject.Find("player").GetComponent<PlayerController>();

        pSpeed = GameObject.Find("player").GetComponent<PlayerController>();

        // enhance = GameObject.Find("exp").GetComponent<ExpBarScript>();

        eSpeed1 = GameObject.Find("Enemy1").GetComponent<Enemy1>();
        //eSpeed1Clone = GameObject.Find("Enemy1(Clone)").GetComponent<Enemy1>();
        //eSpeed2 = GameObject.Find("Enemy2").GetComponent<Enemy2>();
        //eSpeed2Clone = GameObject.Find("Enemy2(Clone)").GetComponent<Enemy2>();
        eSpeed3 = GameObject.Find("Enemy3").GetComponent<Enemy3>();
        //eSpeed3Clone = GameObject.Find("Enemy3(Clone)").GetComponent<Enemy3>();
        eSpeed4 = GameObject.Find("Enemy4").GetComponent<Enemy4>();
        //eSpeed4Clone = GameObject.Find("Enemy4(Clone)").GetComponent<Enemy4>();

        speedTemp = pSpeed.speed;
        speedTemp2 = pSpeed.AddSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        // ���V�t�g��������Ă��
        if(Input.GetKey(KeyCode.LeftShift))
        {
            // �G�̓������~�܂�
            eSpeed1.speed = 0.0f;
            //eSpeed1Clone.speed = 0.0f;
            //eSpeed2.speed = 0.0f;
            //eSpeed2Clone.speed = 0.0f;
            eSpeed3.speed = 0.0f;
            //eSpeed3Clone.speed = 0.0f;
            eSpeed4.speed = 0.0f;
            //eSpeed4Clone.speed = 0.0f;
            // ������ʂ�\��
            transform.position = new Vector3(0, 0, 0);
            //// �v���C���[�̍U���͂�0�ɂ���
            //attackTemp = pAttack.strength;
            //pAttack.strength *= 0.0f;
            // �v���C���[�̓������~�߂�
            pSpeed.speed = 0.0f;
            pSpeed.AddSpeed = 0.0f;
        }

        // ���V�t�g�������ꂽ��
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            // ������ʂ����
            transform.position = new Vector3(0, 30, 0);
            // �G�̓������ĊJ����
            eSpeed1.speed += 0.005f;
            //eSpeed1Clone.speed += 0.005f;
            //eSpeed2Clone.speed += 0.005f;
            //eSpeed2Clone.speed += 0.005f;
            eSpeed3.speed += 0.005f;
            //eSpeed3Clone.speed += 0.005f;
            eSpeed4.speed += 0.005f;
            //eSpeed4Clone.speed += 0.005f;
            //// �v���C���[�̍U���͂����ɖ߂�
            //pAttack.strength = attackTemp;
            // �v���C���[�̓������ĊJ����
            pSpeed.speed = speedTemp;
            pSpeed.AddSpeed = speedTemp2;
        }
    }
}
