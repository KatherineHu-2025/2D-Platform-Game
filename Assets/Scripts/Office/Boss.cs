using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
     private SpriteRenderer spriteRenderer;
    public Transform raycastOrigin; 
    public float raycastDistance = 3f; 
    public LayerMask layerMask;
    public TMP_Text myText;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Get the SpriteRenderer component
        StartCoroutine(FlipAndDetect()); // Start the coroutine to flip direction and constantly detect
    }

    // Coroutine to flip the character direction and constantly detect objects when facing left
    IEnumerator FlipAndDetect()
    {
        while (true) // Infinite loop to continuously flip direction and detect
        {
            // Wait for a random time between 1 to 3 seconds before flipping
            yield return new WaitForSeconds(Random.Range(1f, 3f));

            // Flip the sprite along the x-axis
            spriteRenderer.flipX = !spriteRenderer.flipX;

            // If facing left, check for collisions. Else, wait to flip back after a random period
            if (spriteRenderer.flipX)
            {
                float timeToFlipBack = Random.Range(1f, 3f); // Time after which the character will flip back
                float startTime = Time.time; // Record the start time

                while (spriteRenderer.flipX && (Time.time - startTime) < timeToFlipBack) // Check for duration and if still facing left
                {
                    RaycastHit2D hit = Physics2D.Raycast(raycastOrigin.position, Vector2.left, raycastDistance, layerMask);
                    if (hit.collider != null)
                    {   
                        if(hit.collider.gameObject.GetComponent<Character>().money >= 100){
                            Debug.Log("Your work for today is finished. You can leave now.");
                            myText.text = "Your work for today is finished. You can leave now.";
                        }
                        else{
                            SceneManager.LoadScene("Office");
                            yield break; // Exit the coroutine if an object is detected and the scene is changed
                        }
                    }

                    // Wait a short amount of time before checking again
                    yield return new WaitForSeconds(0.01f);
                }

                // Flip back to facing right after the specified period if no collision was detected
                spriteRenderer.flipX = false;
            }
        }
    }

    void OnDrawGizmos()
    {
        if (raycastOrigin != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(raycastOrigin.position, raycastOrigin.position + Vector3.left * raycastDistance);
        }
    }
}
