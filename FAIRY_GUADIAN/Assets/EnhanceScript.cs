using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnhanceScript : MonoBehaviour
{
    PlayerController attack;

    ExpBarScript enhance;

    // Start is called before the first frame update
    void Start()
    {
        attack = GameObject.Find("player").GetComponent<PlayerController>();
        enhance = GameObject.Find("exp").GetComponent<ExpBarScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.position = new Vector3(0, 0, 0);
            if (Input.GetKeyDown(KeyCode.A) && enhance.enhance > 0)
            {
                attack.strength += 0.5f;
                enhance.enhance -= 1;
            }
            else if(Input.GetKeyDown(KeyCode.B) && enhance.enhance> 0)
            {

            }
        } 
    }
}
