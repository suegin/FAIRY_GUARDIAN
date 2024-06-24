using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float fMoveSpeed = 7.0f;  // �ړ��l
    Vector3 bulletPoint;                // �e�̈ʒu
    public float MoveSpeed = 20.0f;         // �ړ��l
    int frameCount = 0;             // �t���[���J�E���g
    const int deleteFrame = 180;    // �폜�t���[��


    // �ǉ�
    public GameObject BulletObj;     // �e�̃Q�[���I�u�W�F�N�g
    // Start is called before the first frame update
    void Start()
    {
        bulletPoint = transform.Find("BulletPoint").localPosition;
        Instantiate(BulletObj, transform.position + bulletPoint, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        // �{�^�����������Ƃ�
        if (Input.GetButtonDown("Fire1"))
        {
            // �e�̐���
            Instantiate(BulletObj);
        }

        // �ʒu�̍X�V
        transform.Translate(MoveSpeed * Time.deltaTime, 0, 0);

        // ���t���[���ŏ���
        if (++frameCount > deleteFrame)
        {
            Destroy(gameObject);
        }
    }
}
