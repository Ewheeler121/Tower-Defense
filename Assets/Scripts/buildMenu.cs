using UnityEngine;

public class BuildMenu : MonoBehaviour {
    public GameObject TowerPrefab;
    public GameObject StickyTowerPrefab;
    
    private gameManager manager;
    
    public void Start() {
        manager = GameObject.Find("GameManager").GetComponent<gameManager>();
    }

    public void SpawnTower() {
        Transform tile = GameObject.Find("Build Menu(Clone)").transform.parent;
        Instantiate(TowerPrefab, tile.position, tile.rotation, null);

        //destroy the menu
        manager.menuOpen = false;
        GetComponentInParent<BuildableSpace>().hideMenu();
    }
    
    public void SpawnStickyTower() {
        Transform tile = GameObject.Find("Build Menu(Clone)").transform.parent;
        Instantiate(StickyTowerPrefab, tile.position, tile.rotation, null);

        //destroy the menu
        manager.menuOpen = false;
        GetComponentInParent<BuildableSpace>().hideMenu();
    }

    public void Upgrade() {
        SpawnTower();
    }

    public void Close() {
        manager.menuOpen = false;
        GetComponentInParent<BuildableSpace>().hideMenu();
    }
}
