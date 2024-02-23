using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRegionCue : MonoBehaviour
{
    // Start is called before the first frame update
    private int time = 0;
    public Transform raycastOrigin; 
    public float raycastDistance = 3f;
    public LayerMask layerMask;

    private bool canCastRay = true;

    void Update()
    {
        shootRaycast();
    }

    void shootRaycast(){
        if (canCastRay)
        {   
            RaycastHit2D hit = Physics2D.Raycast(raycastOrigin.position, Vector2.up, raycastDistance, layerMask);
            if (hit.collider != null)
            {   
                if(time == 0){
                Debug.Log("Go back to work! Don't sneak out when boss is WATCHING!");
                time++;
                }
                else{
                Debug.Log("Do you really want to do this?");
                }
                StartCoroutine(DeactivateRaycastTemporarily()); // Deactivate the raycast
            }
        }
    }

    void updateUI(){

    }

    IEnumerator DeactivateRaycastTemporarily()
    {
        canCastRay = false; // Deactivate raycasting
        yield return new WaitForSeconds(3); // Wait for 3 seconds
        canCastRay = true; // Reactivate raycasting
    }

    void OnDrawGizmos()
    {
        if (raycastOrigin != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(raycastOrigin.position, raycastOrigin.position + Vector3.up * raycastDistance);
        }
    }
}
