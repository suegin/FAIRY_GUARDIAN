using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnhanceScript : MonoBehaviour
{
    PlayerController strength;
    ExpBarScript enhance;

    // Start is called before the first frame update
    void Start()
    {
        strength = GameObject.Find("player").GetComponent<PlayerController>();
        enhance = GameObject.Find("exp").GetComponent<ExpBarScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (enhance.enhance > 0)
            {
                strength._strength += 1;
                enhance.enhance -= 1;
                Debug.Log(enhance);
            }
        }
    }
}
