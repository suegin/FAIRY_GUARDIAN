using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnhanceScript : MonoBehaviour
{
    //PlayerController pAttack;

    PlayerController pSpeed;
   
    //ExpBarScript enhance;

    //Testenemy eSpeed;

    //float attackTemp;
    float speedTemp;
    float speedTemp2;

    // Start is called before the first frame update
    void Start()
    {
        //pAttack = GameObject.Find("player").GetComponent<PlayerController>();

        pSpeed = GameObject.Find("player").GetComponent<PlayerController>();

        // enhance = GameObject.Find("exp").GetComponent<ExpBarScript>();

        //eSpeed = GameObject.Find("enemy").GetComponent<Testenemy>();
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
            //eSpeed.speed = 0.0f;
            // ������ʂ�\��
            //transform.position = new Vector3(0, 0, 0);
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
            //transform.position = new Vector3(0, 30, 0);
            // �G�̓������ĊJ����
            //eSpeed.speed += 0.005f;
            //// �v���C���[�̍U���͂����ɖ߂�
            //pAttack.strength = attackTemp;
            // �v���C���[�̓������ĊJ����
            pSpeed.speed = speedTemp;
            pSpeed.AddSpeed = speedTemp2;
        }
    }
}
