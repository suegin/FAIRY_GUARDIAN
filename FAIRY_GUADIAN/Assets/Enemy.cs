using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // �G�v���n�u
    public GameObject Enemy1Prefab;
    // ���ԊԊu�̍ŏ��l
    public float minTime = 2f;
    // ���ԊԊu�̍ő�l
    public float maxTime = 2f;
    // �G�������ԊԊu
    private float interval;
    // �o�ߎ���
    private float time = 0f;
    GameObject Player;

    float speed = 0.005f;
    
    // Start is called before the first frame update
    void Start()
    {
        // ���ԊԊu�����肷��
        //interval = GetRandomTime();
        // Fairy��ǐ�
        Player = GameObject.Find("Player");       
    }

    // Update is called once per frame
    void Update()
    {
        // ���Ԍv��
        time += Time.deltaTime;

        // �o�ߎ��Ԃ��������ԂɂȂ����Ƃ�(�������Ԃ��傫���Ȃ�����)
        if (time > interval)
        {
            // Enemy���C���X�^���X������(��������)
            GameObject Enemy1 = Instantiate(Enemy1Prefab);
            // ���������G�̍��W�����肷��
            Enemy1.transform.position = new Vector3(-4.61f, -0.49f, 0);
            // �o�ߎ��Ԃ����������čēx���Ԍv�����n�߂�
            time = 0f;
            // ���ɔ������鎞�ԊԊu�����肷��
            //interval = GetRandomTime();
        }



        // Enemy��Fairy��ǐՂ���
        float b = Player.transform.position.x - transform.position.x;
        float c = (Player.transform.position.y - transform.position.y);
            
        float dis = (b * b + c *c );
        float a=Mathf.Sqrt(dis);
        float x = Player.transform.position.x - transform.position.x;
        x= x/ a* speed;
        float y = Player.transform.position.y - transform.position.y;
        y = y / a* speed;
        transform.position += new Vector3(x, y, transform.position.z);

        Debug.Log(Player.transform.position);

     
    }

}
