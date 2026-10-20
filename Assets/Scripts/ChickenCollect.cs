using UnityEngine;

public class ChickenCollect : MonoBehaviour

{
    public ScoreManager scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scoreManager.AddChicken();
            Destroy(gameObject);
        }
    }
}
 
