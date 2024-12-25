using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private List<Canvas> allCanvases; 
    private Canvas activeCanvas; 

    public void OpenCanvas(Canvas targetCanvas)
    {
        foreach (Canvas canvas in allCanvases)
        {
            canvas.gameObject.SetActive(false);
        }
        
        if (targetCanvas != null)
        {
            targetCanvas.gameObject.SetActive(true);
            activeCanvas = targetCanvas;
        }
        else
        {
            Debug.LogError("Target Canvas is not assigned!");
        }
    }
}