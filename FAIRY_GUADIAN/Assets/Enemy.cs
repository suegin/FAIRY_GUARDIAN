using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  
    GameObject Player;

    float speed = 0.010f;

    // Start is called before the first frame update
    void Start()
    {

        // FairyÇí«ê’
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // EnemyÇ™FairyÇí«ê’Ç∑ÇÈ
        float b = Player.transform.position.x - transform.position.x;
        float c = (Player.transform.position.y - transform.position.y);

        float dis = (b * b + c * c);
        float a = Mathf.Sqrt(dis);
        float x = Player.transform.position.x - transform.position.x;
        x = x / a * speed;
        float y = Player.transform.position.y - transform.position.y;
        y = y / a * speed;
        transform.position += new Vector3(x, y, transform.position.z);

        // Debug.Log(Player.transform.position);


    }

}
