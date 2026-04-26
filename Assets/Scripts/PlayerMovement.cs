using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = 0, vertical = 0;
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) horizontal = 1;
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) horizontal = -1;
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) vertical = 1;
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) vertical = -1;

        Vector2 movement = new Vector2(horizontal, vertical).normalized;
        transform.Translate(movement * speed * Time.deltaTime);

        float currentSpeed = movement.magnitude;
        _animator.SetFloat("Speed", currentSpeed);

        if (currentSpeed > 0.01f)
        {
            if (movement.x != 0)
                GetComponent<SpriteRenderer>().flipX = movement.x < 0;
        }
    }
}
