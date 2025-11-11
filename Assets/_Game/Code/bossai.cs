using UnityEngine;

public enum bossState
{
    Idle,
    Attacking

}

public class BigBoss_AI : MonoBehaviour
{
    public Transform playerPosition;
    int hysteresis = 2;
    SpriteRenderer spriteRenderer;
    public int attackDistance; 
    // Current state of the Big Boss
    public bossState currentState = bossState.Idle;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        // get distance to player
        float distanceToPlayer = Vector2.Distance(transform.position, playerPosition.position);
        switch (currentState)
        {
            case bossState.Idle:
                if (distanceToPlayer < attackDistance)
                {
                    currentState = bossState.Attacking;
                    spriteRenderer.color = Color.red;
                }
                break;

            case bossState.Attacking:
                if (distanceToPlayer > attackDistance + hysteresis)
                {
                    currentState = bossState.Idle;
                    spriteRenderer.color = Color.white;
                }
                break;
        }
    }
}

