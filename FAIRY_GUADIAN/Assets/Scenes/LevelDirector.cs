using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelDirector : MonoBehaviour
{
    public int level = 1;
    TextMeshProUGUI levelText;
    // Start is called before the first frame update
    void Start()
    {
       levelText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        // ƒŒƒxƒ‹‚ð•\Ž¦
        levelText.text = "level:" + level;
    }
}
