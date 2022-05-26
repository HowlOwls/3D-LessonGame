using UnityEngine;
[CreateAssetMenu(fileName = "SpawnManagerPreset", menuName = "ScriptableObject/SpawnManagerPreset", order= 1)]
public class SpawnManagerPreset : ScriptableObject
{
  [SerializeField] private GameObject[] _entity;
  [SerializeField] private int _numberOfPrefabsCreate;
  [SerializeField] private string _prefabName;


    public GameObject[] Entity => _entity;
    public int NumberOfPrefabsCreate => _numberOfPrefabsCreate;
    public string PrefabName => _prefabName;
}
