using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveChest : MonoBehaviour
{
    [SerializeField] Camera camera;
    [SerializeField] Transform chestTransform;

    Rigidbody rg;

    bool isTriggering, isChestMoving;

    // Start is called before the first frame update
    void Start()
    {
        isTriggering = false; isChestMoving = false;
        rg = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (isChestMoving)
        {
            

            Vector3 mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);

            rg.freezeRotation = true;
            
            //camera.look
            chestTransform.position = new Vector3(mousePosition.x + camera.transform.forward.x * 5f, mousePosition.y + camera.transform.forward.y * 5f, mousePosition.z + camera.transform.forward.z * 5f);

            if (Input.GetMouseButtonDown(0))
                isChestMoving = false;
        }
        else
        {
            rg.freezeRotation = false;
        }

    }

    public void Activate()
    {
        Debug.Log("ACtivate");

        isChestMoving = true;
    }
}
