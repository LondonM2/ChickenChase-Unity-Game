using UnityEngine;

public class FoodObstacle : MonoBehaviour
{
    public LifeManager lifeManager;
    public AudioClip hurtSound;
    public ParticleSystem hitParticles;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            lifeManager.LoseLife();

            AudioSource.PlayClipAtPoint(hurtSound, transform.position);

            if (hitParticles != null)
            {
                hitParticles.Play();
            }

            Destroy(gameObject);
        }
    }
}