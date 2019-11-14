using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int score;

    public int goalCount;
    public TextMeshProUGUI scoreText;
    public GameObject winPanel;

    PlayerController pc;
    
    private void Start()
    {
        score = 0;
        scoreText.SetText("" + score);

        winPanel.SetActive(false);

        pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    public void AddScore()
    {
        score += 1;
        scoreText.SetText("" + score);
    }

    private void Update()
    {
        if (score >= goalCount)
        {
            pc.isWon = true;
            winPanel.SetActive(true);
        }
    }
}
