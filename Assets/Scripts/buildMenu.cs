using UnityEngine;

public class BuildMenu : MonoBehaviour {
    public GameObject TowerPrefab;

    public void SpawnTower() {
        Transform tile = GameObject.Find("Build Menu(Clone)").transform.parent;
        Debug.Log($"Creating tower at {tile.position}, tile name {tile.name}");
        Instantiate(TowerPrefab, tile.position, tile.rotation, null);

        //destroy the menu
        GetComponentInParent<BuildableSpace>().hideMenu();
    }

    public void Upgrade() {
        Debug.Log("Upgrade");
        GetComponentInParent<BuildableSpace>().hideMenu();
    }

    public void Close() {
        GetComponentInParent<BuildableSpace>().hideMenu();
    }
}
