using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] float damage = 40f;

    PlayerHealth target;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    public void AttachHitEvent()
    {
        if (target == null) { return; }
        target.TakeDamage(damage);
        Debug.Log("bang bang");
    }
}
