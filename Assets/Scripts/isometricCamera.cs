using UnityEngine;

public class IsometricCamera: MonoBehaviour {
    public float panSpeed;

    public float minZoom;
    public float maxZoom;
    public float zoomSpeed;
    public float zoomSmooth;
    
    private float currentZoom;
    private Camera mainCamera;

    void Start() {
        mainCamera = GetComponentInChildren<Camera>();
    }

    void Update() {
        currentZoom = Mathf.Clamp(currentZoom - Input.mouseScrollDelta.y * zoomSpeed * Time.deltaTime, minZoom, maxZoom);
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        transform.position += Quaternion.Euler(0, mainCamera.transform.eulerAngles.y, 0) * new Vector3(input.x, 0, input.y) * (panSpeed * Time.deltaTime);
        mainCamera.orthographicSize =  Mathf.Lerp(mainCamera.orthographicSize, currentZoom, zoomSpeed * Time.deltaTime);
    }
}
