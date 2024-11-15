using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _Platform
{
    public class PlayerCard : MonoBehaviour
    {
        public Image _avatarImage;
        public TMP_Text _nicknameText;

        public void SetPlayerConfig(PlayerConfig playerConfig)
        {
            _avatarImage.sprite = playerConfig._avatar;
            _nicknameText.SetText(playerConfig._nickname);
        }
    }
}