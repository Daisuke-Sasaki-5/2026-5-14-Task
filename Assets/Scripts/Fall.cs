using UnityEngine;

public class Fall : MonoBehaviour
{
    private RectTransform recttransform;

    [SerializeField] private float speed = 300f;

    private void Awake()
    {
        recttransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        recttransform.anchoredPosition += Vector2.down * speed * Time.deltaTime;

        if(recttransform.anchoredPosition.y <= -1000f)
        {
            Destroy(gameObject);
        }
    }
}
