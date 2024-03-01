using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;

    // Update is called once per frame
    void LateUpdate () {
<<<<<<< HEAD
        transform.position = player.transform.position + new Vector3(1, 0, -5);
=======
        transform.position = player.transform.position + new Vector3(0, 0, -5);
>>>>>>> 0e0447a56c27b2733b24e7b6ff62aa12bca21c38
    }
}
