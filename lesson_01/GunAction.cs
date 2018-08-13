using UnityEngine;

public class GunAction : MonoBehaviour
{
    public Rigidbody bullet;
    public Transform bulletPoint;
    public float bulletSpeed;

    public void Update()
    {
        // Check for Fire1 input and instantiate bullet prefab at bulletPoint         
        if ((Input.GetButtonDown("Fire1")))
        {
            Rigidbody bulletInstance = Instantiate(bullet, bulletPoint.transform.position, bulletPoint.transform.rotation);

            // The local up direction of the gun is transformed into world space.
            Vector3 gunDirection = transform.TransformDirection(Vector3.up);
            bulletInstance.AddForce(gunDirection * bulletSpeed, ForceMode.Impulse);
        }
    }
}
