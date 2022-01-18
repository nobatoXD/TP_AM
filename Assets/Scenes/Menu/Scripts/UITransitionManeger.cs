using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class UITransitionManeger : MonoBehaviour
{
    public CinemachineVirtualCamera currectCamera;
    public CinemachineVirtualCamera target;

    #region PlayGame Method Variavels
    private float timer;
    private bool startTimer;
    private static float camTravelTime = 3.2f;
    #endregion


    public void Start()
    {
        currectCamera.Priority++;
        startTimer = false;
     
        
    }
    public void UpdateCamera(CinemachineVirtualCamera target)
    {
     
        currectCamera.Priority--;
        currectCamera = target;
        currectCamera.Priority++;
    }
    public void CheckIfCamIsPlay(CinemachineVirtualCamera target, CinemachineVirtualCamera current)
    {
        if (currectCamera.Name == target.Name)
            startTimer = true;
        else startTimer = false;
    }
    public void Update()
    {
        PlayGame();
    }

    private void PlayGame()
    {     
        if (startTimer) timer += Time.deltaTime;

        CheckIfCamIsPlay(target, currectCamera);

        Debug.Log(startTimer);

        if (startTimer && timer >= camTravelTime)
        {
            timer = 0;
            startTimer = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
