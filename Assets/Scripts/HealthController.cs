using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour
{
    public int hp = 1;
    public bool isEnemy = true;
    public bool hasTakenDamage;
    public int maxHealth = 100;

    void Update()
    {
        if (hp > maxHealth)
        {
            hp = maxHealth;
        }
    }
    public void Damage(int damageCount)
    {
        hp -= damageCount;

        if (hp <= 0)
        {
            
            Destroy(gameObject, 0.1f);
        }
        hasTakenDamage = true;

        gameObject.GetComponent<HealthbarController>().healthSlider.value = hp;

    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        
        ShotController shot = otherCollider.gameObject.GetComponent<ShotController>();
        if (shot != null)
        {
            
            if (shot.isEnemyShot != isEnemy)
            {
                Damage(shot.damage);

                
                Destroy(shot.gameObject); 
            }
        }
    }
}
