using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score;

    public void Gameover()
    {
        Debug.Log("Game Over!");
    }

    public void IncreaseScore()
    {
        score++;
    }
}