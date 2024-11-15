using UnityEngine;

namespace _Platform
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "Platform/Configs/PlayerConfig")]
    public class PlayerConfig : ScriptableObject
    {
        public string _nickname;
        public Sprite _avatar;
    }
}
