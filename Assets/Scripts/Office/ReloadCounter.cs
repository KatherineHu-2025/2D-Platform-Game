using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadCounter : MonoBehaviour
{
    public static int reloadCount = 0;

    void Awake()
    {
        reloadCount++;

        // Optionally, display the current count in the console
        Debug.Log($"Scene has been reloaded {reloadCount} times.");
    }
}
