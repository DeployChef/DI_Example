using Assets.Scripts;
using TMPro;
using UnityEngine;

public class PersistentScoreService : MonoBehaviour, IScoreService
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private int _score;

    void Start()
    {
        _score = PlayerPrefs.GetInt("Score", 0);
        scoreText.text = $"Score: {_score}";
    }

    public void AddScore(int amount)
    {
        _score += amount;
        scoreText.text = $"Score: {_score}";
        PlayerPrefs.SetInt("Score", _score);
        PlayerPrefs.Save();
    }
}
