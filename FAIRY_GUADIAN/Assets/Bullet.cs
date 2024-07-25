using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GameObject Fairy;

    // íeÇÃë¨ìx
    float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        Fairy = GameObject.Find("Fairy");
    }
    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 9.6f);

        float b = Fairy.transform.position.x - transform.position.x;
        float c = (Fairy.transform.position.y - transform.position.y);

        float dis = (b * b + c * c);
        float a = Mathf.Sqrt(dis);
        float x = Fairy.transform.position.x - transform.position.x;
        x = x / a * speed;
        float y = Fairy.transform.position.y - transform.position.y;
        y = y / a * speed;

        transform.position += new Vector3(x, y, 0);
    }
        
    // íeÇ™è¡Ç¶ÇÈèàóù
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Fairy" || collision.tag == "Barrier")
        {
            Destroy(gameObject);
        }
    }
}
