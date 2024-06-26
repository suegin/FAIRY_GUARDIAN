using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnhanceScript : MonoBehaviour
{
    //PlayerController attack;

    //ExpBarScript enhance;

    Testenemy speed;

    // Start is called before the first frame update
    void Start()
    {
        // attack = GameObject.Find("player").GetComponent<PlayerController>();
        // enhance = GameObject.Find("exp").GetComponent<ExpBarScript>();
        speed = GameObject.Find("enemy").GetComponent<Testenemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed.speed *= 0.0f;
            transform.position = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Debug.Log("a");
            transform.position = new Vector3(0, 30, 0);
            speed.speed += 0.005f;
        }
    }
}
//if (Input.GetKeyDown(KeyCode.A) && enhance.enhance > 0)
//{
//    attack.strength += 0.5f;
//    enhance.enhance -= 1;
//}
//else if(Input.GetKeyDown(KeyCode.B) && enhance.enhance> 0)
//{

//}
