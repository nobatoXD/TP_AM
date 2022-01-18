using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class UITransitionManeger : MonoBehaviour
{
    public CinemachineVirtualCamera currectCamera;

    public void Start()
    {
        currectCamera.Priority++;
    }
    public void UpdateCamera(CinemachineVirtualCamera target)
    {
        currectCamera.Priority--;
        currectCamera = target;
        currectCamera.Priority++;
    }
}
