using UnityEngine;

public class BulletAction : MonoBehaviour {
    // Drag explosion prefab here. It should trigger itself when instantiated.
    public Transform explosionPrefab;

    public void OnCollisionEnter(Collision collision)
    {      
        ContactPoint contact = collision.contacts[0];
        Vector3 pos = contact.point;
        Instantiate(explosionPrefab, pos, Quaternion.identity);        
        Destroy(gameObject);
    }
}
