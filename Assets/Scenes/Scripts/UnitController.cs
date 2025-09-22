using UnityEngine;
using System.Collections.Generic;

public class UnitController : MonoBehaviour
{
    [SerializeField] private Camera _mainCamera;
    private GameObject _hoveredUnit;

    private void Start()
    {
        if (_mainCamera == null)
        {
            _mainCamera = Camera.main;
            if (_mainCamera == null)
                Debug.LogError("Camera not found! Please assign a camera in the inspector.");
        }
    }
    void Update()
    {
        HandleMouseHover();
    }

    private void HandleMouseHover()
    { 
      Ray ray = _mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.GetRayIntersection(ray);
    
    
    }

}
