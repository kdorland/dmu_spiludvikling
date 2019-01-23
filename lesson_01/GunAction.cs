using UnityEngine;

public class GunAction : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform bulletEntry;
    public float bulletSpeed;

    public void Update()
    {
        // Check for Fire1 input and instantiate bullet prefab at bullet entry         
        if ((Input.GetButtonDown("Fire1")))
        {
            // The local up direction (green y-axis) of the gun is transformed into world space.
            Vector3 gunDirection = bulletEntry.TransformDirection(Vector3.up);

            // Create bullet
            Rigidbody bulletInstance = Instantiate(bulletPrefab, 
                bulletEntry.transform.position, bulletEntry.transform.rotation);

            // Add force to bullet
            Vector3 forceToAdd = gunDirection * bulletSpeed;
            Debug.Log(forceToAdd);
            bulletInstance.AddForce(forceToAdd, ForceMode.Impulse);
        }
    }
}
