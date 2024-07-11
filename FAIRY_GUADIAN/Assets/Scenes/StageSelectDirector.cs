using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelectDirector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
