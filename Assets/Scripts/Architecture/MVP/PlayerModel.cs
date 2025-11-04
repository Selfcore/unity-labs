using System;
using UnityEngine;

public class PlayerModel
{
    private float _health;
    
    public event Action<float> OnHealthChanged; 
    
    public float Speed { get; set; } = 50f;
    public float JumpForce { get; set; } = 20f;
    public bool IsGrounded { get; set; }

    public float Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
            OnHealthChanged?.Invoke(_health);
        }
    }

    public PlayerModel(float maxHealth)
    {
        _health = maxHealth;
    }
}
