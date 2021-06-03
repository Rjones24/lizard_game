using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class OnDamagedEvent : UnityEvent<int> { }

public class Health : MonoBehaviour
{

    public int health = 10;
    public UnityEvent onDie;
    public OnDamagedEvent onDamaged;

    public void TakeDamage(int damage)
    {
        health -= damage;

        onDamaged.Invoke(health);

        if (health <=0 )
        {
            onDie.Invoke();
        }
    }
}
