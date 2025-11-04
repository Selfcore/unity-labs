using ProjectAssets.Scripts.Architecture.MVP;
using ProjectAssets.Scripts.Architecture.MVP.Player;
using UnityEngine;

namespace ProjectAssets.Scripts.Architecture
{
    public class PlayerInstaller : MonoBehaviour
    {
        [SerializeField] private PlayerView _playerView;
        [SerializeField] private HealthView _playerHealthView;
        
        private PlayerPresenter _playerPresenter;
        private HealthPresenter _playerHealthPresenter;

        private const float MAX_HEALTH_POINTS = 100.0f;

        private void Awake()
        {
            PlayerModel model = new PlayerModel(MAX_HEALTH_POINTS);
            _playerPresenter = new PlayerPresenter(model, _playerView);
            _playerHealthPresenter = new HealthPresenter(model, _playerHealthView);
        }

        private void OnDestroy()
        {
            _playerPresenter?.Dispose();
            _playerHealthPresenter?.Dispose();
        }
    }
}