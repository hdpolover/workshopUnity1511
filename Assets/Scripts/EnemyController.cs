using UnityEngine;

public class EnemyController : MonoBehaviour
{
    ScoreManager sm;

    private void Start()
    {
        sm = FindObjectOfType<ScoreManager>();
    }
    
    private void Update()
    {
        transform.Rotate(0f, 3f, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        sm.AddScore();
    }
}
