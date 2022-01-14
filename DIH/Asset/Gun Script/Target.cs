using UnityEngine;

public class Target : MonoBehaviour {

    public float health = 50f;

    public void TakeDamage (float amount)
    {
        health -= amount; //추가
        if(health <= 0f)
        {
            Die();

        }
    }

    void Die ()
    {
        Destroy(gameObject);
    }
}
