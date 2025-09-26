using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Tower : MonoBehaviour
{
    [Header("Health Settings")]
    public float health = 100f;
    public float damageAmount = 25f;
    public TextMeshProUGUI healthText;

    [Header("Shooting Settings")]
    public GameObject projectilePrefab; // Assign a bullet prefab in inspector
    public Transform shootPoint; // Empty GameObject at the muzzle
    public float fireRate = 2f; // seconds between shots
    private float fireTimer = 0f;

    private Transform target; // Current enemy target

    private void Start()
    {
        UpdateHealthText();
    }

    private void Update()
    {
        // Count down time
        fireTimer -= Time.deltaTime;

        // If we have a target and cooldown is ready -> shoot
        if (target != null && fireTimer <= 0f)
        {
            Shoot();
            fireTimer = fireRate; // reset cooldown
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);
        // If your projectile has a script for movement:
        bullet.GetComponent<Rigidbody>().linearVelocity = (target.position - shootPoint.position).normalized * 10f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            target = other.transform; // lock onto enemy
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy") && other.transform == target)
        {
            target = null; // lost the enemy
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Projectile"))
        {
            health -= damageAmount;
            UpdateHealthText();

            if (health <= 0)
            {
                health = 0;
                Destroy(gameObject);
            }
        }
    }

    private void UpdateHealthText()
    {
        if (healthText != null)
            healthText.text = "Health: " + Mathf.RoundToInt(health);
    }
}
