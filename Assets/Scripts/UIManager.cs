using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{ 
    public static UIManager Instance;

    [Header("Start UI")]
    public TextMeshProUGUI startText;

    [SerializeField] private TextMeshProUGUI scoreText;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (GameManager.instance.IsStarted)
        {
            scoreText.text = "Score:" + GameManager.instance.GetScore();
        }
    }

    // ==== Start UI ====
    public void ShowStartUI(bool show)
    {
        startText?.gameObject.SetActive(show);
    }
}
