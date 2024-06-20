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

        // Fairy‚ğ’ÇÕ
        Barrier = GameObject.Find("Barrier");
    }

    // Update is called once per frame
    void Update()
    {
        
        // Enemy‚ªFairy‚ğ’ÇÕ‚·‚é
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

    // ƒoƒŠƒA‚ÆÚG‚µ‚Ä‚¢‚éŠÔ
    void OnTriggerStay2D(Collider2D other)
    {
        // “®‚«‚ğ~‚ß‚é
        if (other.gameObject.tag == "Barrier")
        {
            // Debug.Log("‚ ");
            speed = 0.000001f;
        }
    }
}
