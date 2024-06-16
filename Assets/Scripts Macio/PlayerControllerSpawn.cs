using UnityEngine;

public class PlayerControllerSpawn : MonoBehaviour
{
    public ScoreManager scoreManager; // Reference to the ScoreManager

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("OnTriggerEnter called");
        if (collision.gameObject.CompareTag("Collectible"))
        {
            if (scoreManager == null)
            {
                Debug.LogError("ScoreManager is not assigned!");
                return;
            }

            scoreManager.IncreaseScore(1); // Increase the score by 1
            Debug.Log("Collectible collected! Score: " + scoreManager.GetScore());
            Destroy(collision.gameObject);
        }
    }
}
