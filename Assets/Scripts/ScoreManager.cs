using Assets.Scripts;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour, IScoreService
{
    [SerializeField] private TextMeshProUGUI scoreText;

    public static ScoreManager Instance { get; private set; }
    private int _score;

    void Awake() => Instance = this;

    public void AddScore(int amount)
    {
        _score += amount;
        scoreText.text = $"Score: {_score}";
        Debug.Log($"Score +{amount} = {_score}");
    }
}
