using System;
using UnityEngine;

namespace ProjectAssets.Scripts.Architecture.MVP
{
    public interface IPlayerView
    {
        public event Action<float> OnInputChanged;
        public event Action OnJumped;
        public event Action OnLanded;
        public event Action OnObstacleHit;

        void Move(float horizontalInput, float speed);
        void Jump(float jumpForce);
    }
}