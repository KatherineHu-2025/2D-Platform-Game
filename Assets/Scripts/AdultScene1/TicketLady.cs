using UnityEngine;
using UnityEngine.SceneManagement;

public class TicketLady : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider collision)
    {   
        if(collision.CompareTag("Player") && !Character.withTicket){
            SceneManager.LoadScene("AdultScene1");
        }
    }
}
