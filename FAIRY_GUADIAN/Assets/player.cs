using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void Update()
    {
       
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
       if(collision.gameObject.tag=="Enemy")
        {
            Debug.Log("1damage");
        }
    }
}
