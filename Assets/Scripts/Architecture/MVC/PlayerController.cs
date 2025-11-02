using System;
using ProjectAssets.Scripts.Architecture.MVC;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerView _view;

    private readonly PlayerModel _player = new PlayerModel();
    private float _horizontalInput = 0f;

    private void Awake()
    {
        _view.OnGrounded += OnGrounded;
    }

    private void OnGrounded()
    {
        _player.IsGrounded = true;
    }

    private void Update()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");
        _view.Move(_horizontalInput, _player.Speed);
        
        if (Input.GetKeyDown(KeyCode.Space) && _player.IsGrounded)
        {
            _player.IsGrounded = false;
            _view.Jump(_player.JumpForce);
        }
    }

    private void OnDestroy()
    {
        _view.OnGrounded -= OnGrounded;
    }
}
