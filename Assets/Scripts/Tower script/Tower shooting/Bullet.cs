using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;
    public float speed = 10f;
    [SerializeField] private int damage;


    public void Seek(Transform _target, int _damage)
    {
        target = _target;
        damage = _damage;
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            enemyHealth enemHealth = other.GetComponent<enemyHealth>();

            enemHealth.TakeDamage(damage);
        }

        
    }

}

   