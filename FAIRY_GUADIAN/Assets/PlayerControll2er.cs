using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private int count;
    public float strength = 1;
    public float speed = 0.07f;
    public float AddSpeed = 1;
    Rigidbody2D rigid2D;
    float xLimit = 8.3f;
    float yLimit = 4.3f;
    BarrierDirector barrierDirector;
    BoxCollider2D boxCol;
    private float sizeCount =1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
        count = 0;
        barrierDirector = GetComponent<BarrierDirector>();
        boxCol = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); // �f�t�H���g���E�����̉摜�̏ꍇ
        Vector3 scale = transform.localScale; // �X�P�[���l���o��
        // ���������ꂽ��
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * AddSpeed, 0, 0); // ����1������
            scale.x = -0.1f; // ���]����i�������j
            
        }
        transform.localScale = scale; // ���������

        // ���������ꂽ��
        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            transform.Translate(speed * AddSpeed, 0, 0); // �E��1������
            scale.x = 0.1f; // ���̂܂܁i�E�����j
        }
        transform.localScale = scale; // ���������

        // ���������ꂽ��
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, speed * AddSpeed, 0); // ���1������
            
        }

        // ���������ꂽ��
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -speed * AddSpeed, 0); // ����1������
        }

        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, -xLimit, xLimit);
        playerPos.y = Mathf.Clamp(playerPos.y, -4.7f, yLimit);
        transform.position = playerPos;

        // Q�������ꂽ��
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(count < 5)       // 5��܂�
            {
                Debug.Log(sizeCount);
                strength += 5;     // �U���͂�5�オ��
                AddSpeed += 1.2f;      // ���x��1.2�オ��
                sizeCount += 0.5f;
                count++;
                boxCol.size = new Vector2(sizeCount, sizeCount);
                
                
            }
            
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            barrierDirector.barrierHp += 5;
            Debug.Log(barrierDirector.barrierHp);
        }

        

    }
   
}



