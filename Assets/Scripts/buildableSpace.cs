using UnityEngine;

public class BuildableSpace : MonoBehaviour {
    public Material baseMaterial;
    public Material highlightMaterial;
    public GameObject buildMenu;

    private gameManager manager;
    private GameObject menu;
    private bool showingMenu = false;
    
    public void Start() {
        manager = GameObject.Find("GameManager").GetComponent<gameManager>();
        gameObject.GetComponent<MeshRenderer>().material = baseMaterial;
    }

    public void showMenu() {
        if(showingMenu) {
            return;
        }

        menu = Instantiate(buildMenu, transform);
        showingMenu = true;
        gameObject.GetComponent<MeshRenderer>().material = highlightMaterial;
    }

    public void hideMenu() {
        if(menu != null) {
            Destroy(menu);
        }

        showingMenu = false;
        gameObject.GetComponent<MeshRenderer>().material = baseMaterial;
    }
    
    public void OnMouseDown() {
        if(!manager.menuOpen) {
            manager.menuOpen = !manager.menuOpen;
            showMenu();
        }
    }
}
