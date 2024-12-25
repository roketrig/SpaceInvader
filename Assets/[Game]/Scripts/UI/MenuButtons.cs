using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] private Canvas targetCanvas;
    private CanvasManager canvasManager; 

    private void Start()
    {
        canvasManager = FindObjectOfType<CanvasManager>();
        if (canvasManager == null)
        {
            Debug.LogError("CanvasManager not found in the scene!");
        }
    }

    public void OnButtonPressed()
    {
        if (canvasManager != null && targetCanvas != null)
        {
            canvasManager.OpenCanvas(targetCanvas);
        }
        else
        {
            Debug.LogError("CanvasManager or TargetCanvas is not assigned!");
        }
    }
}