using Assets.Scripts;
using UnityEngine;
using VContainer;

public class PlayerCollect : MonoBehaviour
{
    private IScoreService _scoreService;

    [Inject]
    public void Construct(IScoreService scoreService)
    {
        _scoreService = scoreService;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            _scoreService.AddScore(10);
            Destroy(other.gameObject);
        }
    }
}
