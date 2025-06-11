using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject projectilePrefab; 
    public Transform shootPoint;        
    public float shootForce = 700f;    

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(shootPoint.forward * shootForce);
        }

        Destroy(projectile, 3f);
    }
}
