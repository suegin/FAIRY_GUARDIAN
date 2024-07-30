using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageSelectDirector : MonoBehaviour
{
    ChangeColorRGBA2 ChangeColorRGBA2;
    private Image FadeImage;
    // Start is called before the first frame update
    void Start()
    {
        FadeImage = GetComponent<Image>();
        ChangeColorRGBA2 = GetComponent<ChangeColorRGBA2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ChangeColorRGBA2 != null & Input.GetKeyUp(KeyCode.Q))
        {
            ChangeColorRGBA2.FadeoutOn();
            ChangeColorRGBA2.Update();
            
        }
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene("GameScene");

        TitleBGMScript.DontDestroyEnabled = false;

        GameObject obj = GameObject.Find("Title&SelectSceneBGM");

        // 指定したオブジェクトを削除
        Destroy(obj);
    }
}
