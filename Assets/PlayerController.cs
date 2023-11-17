using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform _comTransform;
    private SpriteRenderer _comSpriteRenderer;
    public float speed;
    public int xDirection = 1;
    public int yDirection = 1;
    // Start is called before the first frame update
    void Awake()
    {
        _comTransform = GetComponent<Transform>();
        _comSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _comTransform.position = new Vector2(_comTransform.position.x + speed * xDirection * Time.deltaTime, _comTransform.position.y + speed * yDirection * Time.deltaTime);

        if (_comTransform.position.x > 8.2f || _comTransform.position.x < -8.2f)
        {
            xDirection = xDirection * -1;
            _comSpriteRenderer.flipX = !_comSpriteRenderer.flipX;
        }

        if (_comTransform.position.y > 4.2f || _comTransform.position.y < -4.2f)
        {
            yDirection = yDirection * -1;
            _comSpriteRenderer.flipY = !_comSpriteRenderer.flipY;
        }
    }
}
