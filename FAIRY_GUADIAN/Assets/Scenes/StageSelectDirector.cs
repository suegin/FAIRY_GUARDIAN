using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageSelectDirector : MonoBehaviour
{
    ChangeColorRGBA ChangeColorRGBA;
    private Image FadeImage;
    // Start is called before the first frame update
    void Start()
    {
        FadeImage = GetComponent<Image>();
        ChangeColorRGBA = GetComponent<ChangeColorRGBA>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            ChangeColorRGBA.FadeoutOn();
            ChangeColorRGBA.Update();
            
        }
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
