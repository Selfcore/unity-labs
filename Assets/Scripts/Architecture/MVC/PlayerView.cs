using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerView : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    
    public Action OnGrounded;

    public void Move(float horizontalInput, float speed)
    {
        _rigidbody.linearVelocityX = horizontalInput * speed;
    }

    public void Jump(float jumpForce)
    {
        _rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            OnGrounded?.Invoke();
        }
    }
}
