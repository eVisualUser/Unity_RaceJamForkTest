using UnityEngine;

public class MapManager : MonoBehaviour
{
    [Header("REFERENCE")] 
    public MapConfig mapConfig;
    public MapView mapView;
    public MapGenerator mapGenerator;
    
    public Map currentMap;
    
    public void GenerateMap()
    {
        currentMap = mapGenerator.GetMap(mapConfig);
        mapView.ShowMap(currentMap, mapConfig);
    }
}
