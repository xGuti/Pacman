using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _rcRange = 1f;
    [SerializeField] private Vector2 _direction = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        var raycastHit = Physics2D.Raycast(transform.position, _direction, _rcRange, LayerMask.GetMask("Map"));

        if (!raycastHit)
        {
            _rb.MovePosition((Vector2)transform.position+_direction*_speed);
        }
    }
}
