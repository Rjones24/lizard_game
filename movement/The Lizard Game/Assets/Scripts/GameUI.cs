using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{

    public Slider healthBar;
    public Text scoreText;

    public int playerScore = 0;

    private void OnEnable()
    {
        Player.OnUpdateHealth += UpdateHealthBar;
        AddScore.OnSendScore += UpdateScore;
    }

    private void OnDisable()
    {
        Player.OnUpdateHealth -= UpdateHealthBar;
        AddScore.OnSendScore -= UpdateScore;
    }

    private void UpdateHealthBar(int Health)
    {
        healthBar.value = Health;
    }

    private void UpdateScore(int theScore)
    {

        playerScore += theScore;
        scoreText.text = "Score: " + playerScore.ToString();
    }
}
