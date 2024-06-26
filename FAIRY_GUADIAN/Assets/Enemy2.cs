using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
   

    GameObject Barrier;

    GameObject Fairy;

    public GameObject m_shot;// ショットの弾

    private int count = 0;

    float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        Barrier = GameObject.Find("Barrier");
        Fairy = GameObject.Find("Fairy");
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
            Shot();
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
    /// ショットを打ち出す処理
    /// </summary>
    private void Shot()
    {
        count += 1;

        // ６０フレームごとに砲弾を発射する
        if (count % 60 == 0)
        {
            // 弾のインスタンス生成を行う
            GameObject shell = Instantiate(m_shot, transform.position, Quaternion.identity);
        }
    }
}
