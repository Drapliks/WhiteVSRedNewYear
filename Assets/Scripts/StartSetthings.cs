using UnityEngine;

public class StartSetthings : MonoBehaviour
{
    void Start()
    {
        Screen.SetResolution(1920, 1080, true);
        Application.targetFrameRate = 60; 
    }
}
