using UnityEngine;
using UnityEngine.UI;

public class AutoScroll : MonoBehaviour
{
    // Start is called before the first frame update
    public ScrollRect scrollRect;
    public float scrollSpeed = 0.1f;

    void Update()
    {
        if (scrollRect.horizontalNormalizedPosition > 0)
        {
            scrollRect.horizontalNormalizedPosition -= scrollSpeed * Time.deltaTime;
        }
    }
}
