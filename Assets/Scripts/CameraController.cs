using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class CameraController : MonoBehaviour
{
    public Camera mainCamera;
    public Camera leftCamera;
    public Camera RightCamera;

    void Update() {
        ChangeCameras();
    }
    
    private void ChangeCameras() {
        if (Input.GetKeyDown("1")) {
            MainCameraView();
        } else if (Input.GetKeyDown("2")) {
            LeftCameraView();
        }
    }

    public void MainCameraView() {
        mainCamera.enabled = true;
        leftCamera.enabled = false;
    }
    
    public void LeftCameraView() {
        mainCamera.enabled = false;
        leftCamera.enabled = true;
    }
}
