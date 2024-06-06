using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemy : MonoBehaviour
{

    GameObject Fairy;

    float speed = 0.005f;

    // Start is called before the first frame update
    void Start()
    {
        // FairyÇí«ê’
        Fairy = GameObject.Find("Fairy");
    }

    // Update is called once per frame
    void Update()
    {
        // EnemyÇ™FairyÇí«ê’Ç∑ÇÈ
        float b = Fairy.transform.position.x - transform.position.x;
        float c = (Fairy.transform.position.y - transform.position.y);

        float dis = (b * b + c * c);
        float a = Mathf.Sqrt(dis);
        float x = Fairy.transform.position.x - transform.position.x;
        x = x / a * speed;
        float y = Fairy.transform.position.y - transform.position.y;
        y = y / a * speed;
        transform.position += new Vector3(x, y, transform.position.z);
    }
}
