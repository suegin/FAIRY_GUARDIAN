using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    GameObject Barrier;

    GameObject Fairy;

    public GameObject m_shot;// �V���b�g�̒e

    private int count = 0;

    public float speed = 0.01f;

    EnhanceScript shot;

    // Start is called before the first frame update
    void Start()
    {
        Barrier = GameObject.Find("Barrier");
        Fairy = GameObject.Find("Fairy");

        shot = GameObject.Find("Enhance").GetComponent<EnhanceScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float b = Fairy.transform.position.x - transform.position.x;
        float c = (Fairy.transform.position.y - transform.position.y);

        float dis = (b * b + c * c);
        float a = Mathf.Sqrt(dis);
        float x = Fairy.transform.position.x - transform.position.x;
        x = x / a * speed;
        float y = Fairy.transform.position.y - transform.position.y;
        y = y / a * speed;
        if(a >= 5)
        {
            transform.position += new Vector3(x, y, transform.position.z);
        }
        else
        {
            if (shot.shot)
            {
                Shot();
            }
            
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 0;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 0.005f;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Barrier")
        {
            speed = 0.000001f;
        }
    }

    /// <summary>
    /// �V���b�g��ł��o������
    /// </summary>
    private void Shot()
    {
        count += 1;

        // 120�t���[�����ƂɖC�e�𔭎˂���
        if (count % 120 == 0)
        {
            // �e�̃C���X�^���X�������s��
            GameObject shell = Instantiate(m_shot, transform.position, Quaternion.identity);
        }
    }
}
