using System;
using UnityEngine;

public class HealthPresenter : IDisposable
{
    private readonly HealthView _view;
    private readonly PlayerModel _playerModel;

    public HealthPresenter(PlayerModel playerModel, HealthView healthView)
    {
        _view = healthView;
        _playerModel = playerModel;
        _playerModel.OnHealthChanged += HealthChangeHandler;
    }
    
    public void HealthChangeHandler(float health)
    {
        _view.UpdateHealth(health);
    }

    public void Dispose()
    {
        _playerModel.OnHealthChanged -= HealthChangeHandler;
    }
}
