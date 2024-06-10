using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  
    GameObject Barrier;

    float speed = 0.005f;

    // Start is called before the first frame update
    void Start()
    {

        // Fairyを追跡
        Barrier = GameObject.Find("Fairy");
    }

    // Update is called once per frame
    void Update()
    {
        // EnemyがFairyを追跡する
        float b = Barrier.transform.position.x - transform.position.x;
        float c = (Barrier.transform.position.y - transform.position.y);

        float dis = (b * b + c * c);
        float a = Mathf.Sqrt(dis);
        float x = Barrier.transform.position.x - transform.position.x;
        x = x / a * speed;
        float y = Barrier.transform.position.y - transform.position.y;
        y = y / a * speed;
        transform.position += new Vector3(x, y, transform.position.z);

        Debug.Log(Barrier.transform.position);


    }

}
