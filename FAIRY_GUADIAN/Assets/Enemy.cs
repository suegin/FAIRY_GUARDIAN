using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  

    GameObject Barrier;

    GameObject Fairy;


    float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        Barrier = GameObject.Find("Fairy");
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
        transform.position += new Vector3(x, y, transform.position.z);

        // Debug.Log(Player.transform.position);



    }

}
