using System.Net.Http.Headers;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update

    public float health = 50f;
    public GameObject BrokenBottle;


    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        if (BrokenBottle != null)
        {
            Instantiate(BrokenBottle, transform.position, transform.rotation);
        }
        Destroy(gameObject);
    }

}