using UnityEngine;

public class TextureScroller : MonoBehaviour
{

    public float scrollSpeedX = 0f;
    public float scrollSpeedY = -1;

    private Renderer _renderer;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        float offsetX = Time.time * scrollSpeedX;
        float offsetY = Time.time * scrollSpeedY;
        _renderer.material.mainTextureOffset = new Vector2(offsetX, offsetY);
    }
}