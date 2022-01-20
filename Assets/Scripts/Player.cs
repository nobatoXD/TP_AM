using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] Camera camera;

    Ray cameraRay;
    RaycastHit cameraRayHit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraRay = camera.ScreenPointToRay(Input.mousePosition);

        if (Input.GetKeyDown(KeyCode.E))
            RayCasting();
    }

    void RayCasting()
    {
        if (Physics.Raycast(cameraRay, out cameraRayHit))
        {

            GameObject[] objects = FindObjectsOfType<GameObject>();

            foreach(var obj in objects)
            {
                if(obj.name == cameraRayHit.collider.name && obj.tag == "Chests")
                {
                    obj.GetComponent<MoveChest>().Activate();
                }
                else if (obj.name == cameraRayHit.collider.name && obj.tag == "Fan Machine")
                {

                }
                else if (obj.name == cameraRayHit.collider.name && obj.tag == "Chairs")
                {

                }
            }

        }
    }
}
