using UnityEngine;
[CreateAssetMenu(fileName = "SpawnManagerPreset", menuName = "ScriptableObject/SpawnManagerPreset", order= 1)]
public class SpawnManagerPreset : ScriptableObject
{
   public GameObject[] _entity;
   public  int _numberOfPrefabsCreate;
   public string _prefabName;
}
