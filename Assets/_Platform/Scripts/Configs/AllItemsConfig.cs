using UnityEngine;

namespace _Platform
{
    [CreateAssetMenu(fileName = "AllItemsConfig", menuName = "Platform/Configs/AllItemsConfig")]
    public class AllItemsConfig : ScriptableObject
    {
        public ItemConfig[] _itemConfigs;
    }
}