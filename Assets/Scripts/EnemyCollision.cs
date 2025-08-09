using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField]
    private Health _health;
    private void OnCollisionEnter(EnemyCollision other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            other.gameObject.SetActive(false);
            _health.TakeDamage(10);
        }
    }
}
