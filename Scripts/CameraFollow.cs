using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{    
        public Transform target;
        public float trailDistance;
        public float heightOffset;
        public float cameraDelay;

        // Update is called once per frame
        void LateUpdate()
        {
            Vector3 followPos = target.position - target.forward * trailDistance;

            followPos.y += heightOffset;
            transform.position += (followPos - transform.position) * cameraDelay;

            transform.LookAt(target.transform);
        }
    
}
