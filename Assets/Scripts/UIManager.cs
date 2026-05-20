using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{ 
    public static UIManager Instance;

    [Header("Start UI")]
    public TextMeshProUGUI startText;

    [Header("GameOver UI")]
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TextMeshProUGUI resultScoreText;

    [SerializeField] private TextMeshProUGUI scoreText;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        gameOverPanel.SetActive(false);
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

        scoreText?.gameObject.SetActive(!show);
    }

    // ==== GameOver UI ====
    public void ShowGameOver(int score)
    {
        gameOverPanel.SetActive(true);
        scoreText.gameObject.SetActive(false);

        resultScoreText.text = "Score:" + score;
    }
}
