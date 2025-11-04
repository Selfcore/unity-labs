using System;
using UnityEngine;

namespace ProjectAssets.Scripts.Architecture.MVP.Player
{
    public class PlayerPresenter : IDisposable
    {
        private readonly PlayerView _view;
        private readonly PlayerModel _model;
        
        public PlayerPresenter(PlayerModel model, PlayerView view)
        {
            _model = model;
            _view = view;

            _view.OnInputChanged += HandleMove;
            _view.OnJumped += HandleJump;
            _view.OnLanded += HandleLanded;
            _view.OnObstacleHit += ObstacleHitHandler;
        }

        private void HandleMove(float direction)
        {
            if (_model.IsGrounded)
            {
                _view.Move(direction, _model.Speed);
            }
        }

        private void HandleJump()
        {
            if (_model.IsGrounded)
            {
                _model.IsGrounded = false;
                _view.Jump(_model.JumpForce);
            }
        }

        private void HandleLanded()
        {
            _model.IsGrounded = true;
        }

        public void ObstacleHitHandler()
        {
            Debug.Log("Hit!");
            _model.Health -= 10;
        }
        
        public void Dispose()
        {
            _view.OnInputChanged -= HandleMove;
            _view.OnJumped -= HandleJump;
            _view.OnLanded -= HandleLanded;
            _view.OnObstacleHit -= ObstacleHitHandler;
        }
    }
}