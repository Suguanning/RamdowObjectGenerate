using UnityEngine;
using UnityEngine.UI;

public class ScrollViewExample : MonoBehaviour
{
    public ScrollRect scrollView;
    public Scrollbar scrollbar;

    void Start()
    {
        scrollbar.onValueChanged.AddListener(OnScrollbarValueChanged);
    }

    void OnScrollbarValueChanged(float value)
    {
        scrollView.normalizedPosition = new Vector2(scrollView.normalizedPosition.x, value);
    }
}