using UnityEngine;

namespace _Platform
{
    [CreateAssetMenu(fileName = "AllPlayersConfig", menuName = "Platform/Configs/AllPlayersConfig")]
    public class AllPlayersConfig : ScriptableObject
    {
        public PlayerConfig[] _playerConfigs;
    }
}