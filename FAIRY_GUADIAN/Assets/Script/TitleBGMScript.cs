using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleBGMScript : MonoBehaviour
{
    public static bool DontDestroyEnabled = true;
    // Start is called before the first frame update
    void Start()
    {
        if (DontDestroyEnabled)
        {
            // Sceneを遷移してもオブジェクトが消えないようにする
            DontDestroyOnLoad(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
