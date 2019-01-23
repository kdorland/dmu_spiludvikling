using UnityEngine;

public class BulletAction : MonoBehaviour {
    // Drag explosion prefab here. It should trigger itself when instantiated.
    public Transform explosionPrefab;

    public void OnCollisionEnter(Collision collision)
    {      
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);        
        Destroy(gameObject);
    }
}
