using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    int _strength = 1;
    float AddSpeed = 1;
    Rigidbody2D rigid2D;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); // �f�t�H���g���E�����̉摜�̏ꍇ
        Vector3 scale = transform.localScale; // �X�P�[���l���o��
        // ���������ꂽ��
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.07f * AddSpeed, 0, 0); // ����1������
            scale.x = -1; // ���]����i�������j

        }
        transform.localScale = scale; // ���������

        // ���������ꂽ��
        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            transform.Translate(0.07f * AddSpeed, 0, 0); // �E��1������
            scale.x = 1; // ���̂܂܁i�E�����j
        }
        transform.localScale = scale; // ���������

        // ���������ꂽ��
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0.07f * AddSpeed, 0); // ���1������
        }

        // ���������ꂽ��
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -0.07f * AddSpeed, 0); // ����1������
        }

        // Q�������ꂽ��
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _strength += 5;     // �U���͂�5�オ��
            AddSpeed += 1.2f;      // ���x��1.2�オ��
        }

        // W�������ꂽ��
        if(Input.GetKeyDown(KeyCode.W)) 
        { 
                                                //  ���a3.5�̉~�`�̍U���͈�
              

        }

    }
   
}



