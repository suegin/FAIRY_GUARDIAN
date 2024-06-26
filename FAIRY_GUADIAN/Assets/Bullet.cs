using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GameObject Fairy;

    // Start is called before the first frame update
    void Start()
    {
        Fairy = GameObject.Find("Fairy");
    }
    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 5.0f);

        //transform.position += new Vector3(Fairy.position.x, Fairy.position.x,0);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);

        if(collision.tag == "Fairy" /*|| collision.tag == "balia"*/)
        {
            Destroy(gameObject);
        }
    }
}
