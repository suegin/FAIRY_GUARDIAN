using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class Testenemy : MonoBehaviour
{

    GameObject Barrier;

    float speed = 0.005f;

    // Start is called before the first frame update
    void Start()
    {

        // Fairy��ǐ�
        Barrier = GameObject.Find("Barrier");
    }

    // Update is called once per frame
    void Update()
    {
        
        // Enemy��Fairy��ǐՂ���
        float b = Barrier.transform.position.x - transform.position.x;
        float c = (Barrier.transform.position.y - transform.position.y);

        float dis = (b * b + c * c);
        float a = Mathf.Sqrt(dis);
        float x = Barrier.transform.position.x - transform.position.x;
        x = x / a * speed;
        float y = Barrier.transform.position.y - transform.position.y;
        y = y / a * speed;
        transform.position += new Vector3(x, y, transform.position.z);

        // Debug.Log(Barrier.transform.position);


    }

    // �o���A�ƐڐG���Ă����
    void OnTriggerStay2D(Collider2D other)
    {
        // �������~�߂�
        if (other.gameObject.tag == "Barrier")
        {
            // Debug.Log("��");
            speed = 0.000001f;
        }
    }
}
