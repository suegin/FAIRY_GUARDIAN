using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(-0.07f, 0.07f, 0.07f);
    }

    void OnTriggerEnter2D(Collider2D Trigger)
    {
       Destroy(this.gameObject);
    }
}
