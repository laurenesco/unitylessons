using System;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Variables
    public GameObject player;
    private Vector3 cam_offset = new Vector3(0, 6, -8);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // LateUpdate is called once per frame
    private void LateUpdate()
    {
        transform.position = player.transform.position + cam_offset;
    }
}

//In Unity’s frame loop, Update is called before all transforms have finished being modified for 
//the current frame, while LateUpdate is called after all Update calls complete.

//A camera that follows or tracks objects is typically dependent on the final positions of those objects. 
//If the camera logic runs in Update, it may read target transforms before other scripts (movement, 
//physics-driven interpolation, animations) have applied their changes for that frame, causing small 
//positional discrepancies that manifest as jitter.

//By running camera logic in LateUpdate, the camera:

//    - Observes the fully resolved transforms for the frame
//    - Reacts to the final movement state of targets
//    - Avoids frame-to-frame inconsistencies caused by execution order

//This ensures the camera’s transform is updated once, using authoritative data, which results in visually 
//smoother motion—especially for follow, orbit, and look-at behaviors.