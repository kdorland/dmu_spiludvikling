using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    public Transform posA;
    public Transform posB;
    private Vector3 targetPoint;
    public float speed = 1;
    public int pointsIfHit;
    //public ScoreController controller;

    private void Start()
    {
        targetPoint = posA.position;
    }

    private void OnCollisionEnter(Collision collision) {
        //controller.AddScore(pointsIfHit);
        Destroy(gameObject);
    }

    // Move target between targets
    public void Update() {
        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPoint, 
            Time.deltaTime * speed);

        // If distance between targetPoint and pos is below 0.00f, switch pos
        if (Mathf.Abs((transform.position - targetPoint).magnitude) < 0.001f) {
            if (targetPoint == posA.position) {
                targetPoint = posB.position;
            } else {
                targetPoint = posA.position;
            }
        }
    }
}
