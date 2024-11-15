using UnityEngine;
using VContainer;

namespace _Platform
{
    public class PlayersSpawner : MonoBehaviour
    {
        public PlayerCard _playerCardPrefab;
        
        private AllPlayersConfig _allPlayersConfig;

        [Inject]
        void Inject(AllPlayersConfig allPlayersConfig)
        {
            _allPlayersConfig = allPlayersConfig;
        }

        void Awake()
        {
            for (var i = 0; i < _allPlayersConfig._playerConfigs.Length; i++)
            {
                var playerCard = Instantiate(_playerCardPrefab);
                playerCard.transform.position = new Vector3(i * 150, 0, 0);
                playerCard.SetPlayerConfig(_allPlayersConfig._playerConfigs[i]);
            }
        }
    }
}