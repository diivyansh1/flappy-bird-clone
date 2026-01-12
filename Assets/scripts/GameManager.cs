using UnityEngine;
public class GameManager : MonoBehaviour
{
    private int score;
    public script player;
    public void GameOver()
    {
        Debug.Log("Game Over");
    }
    public void IncreaseScore()
    {
        score++;
    }
}
