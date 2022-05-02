using UnityEngine;

public class SpawnerAmmoAndHealth : MonoBehaviour
{

   [SerializeField] private SpawnManagerPreset _spawnManagerPreset;
   [SerializeField] private Transform[] spawnPoints;

   private int _instanceNumber = 1;

   private void Start()
   {
      SpawnEntities();
   }

   private void SpawnEntities()
   {
      var currentSpawnIndexPoint = 0;
      for (var i = 0; i < _spawnManagerPreset._numberOfPrefabsCreate; i++)
      {
         var currenEntity = Instantiate(_spawnManagerPreset._entity[currentSpawnIndexPoint], spawnPoints[currentSpawnIndexPoint].position, Quaternion.identity);
         currenEntity.name = _spawnManagerPreset._prefabName + _instanceNumber;
         currentSpawnIndexPoint = (currentSpawnIndexPoint + 1) % spawnPoints.Length;
         _instanceNumber++;
      }
   }
}
