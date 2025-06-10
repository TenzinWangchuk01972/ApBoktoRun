using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoktoBehaviour : MonoBehaviour
{
    public float forwardMovement;
    public Animator boktoAnimator;
    public Rigidbody boktoRB;
    public float startPosX;
    public float endPosX;
    public float startPosY;
    public float endPosY;

    // Update is called once per frame
    void FixedUpdate()
    {        
        boktoRB.velocity = new Vector3 (boktoRB.velocity.x,boktoRB.velocity.y, forwardMovement);
        Swipe();
        Touch();

       /* if(Input.GetMouseButtonDown(0))
        {
            startPosX = Input.mousePosition.x;
        }
        if (Input.GetMouseButtonUp(0))
        {
            endPosX = Input.mousePosition.x;

            if (endPosX - startPosX > 0)
            { 
                Debug.Log("Right");
            }
            else if(endPosX - startPosX < 0)
            {
                Debug.Log("Left");
            }
        }
        if(Input.GetMouseButton(0))
        {
            startPosY = Input.mousePosition.y;
        }
        if (Input.GetMouseButtonUp (0))
        {
            endPosY = Input.mousePosition.y;

            if (endPosY - startPosY > 0)
            {
                Debug.Log("Up");
            }
            else if (endPosY - startPosY < 0)
            {
                Debug.Log("Down");
            }
        }*/
    }

    private void Touch()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPosX = Input.mousePosition.x;
            startPosY = Input.mousePosition.y;
        }
        if (Input.GetMouseButtonUp(0))
        {
            endPosX = Input.mousePosition.x;
            endPosY = Input.mousePosition.y;
        }       
    }

    private void Swipe()
    {
        var xDisplacement = startPosX - endPosX;
        var yDisplacement = startPosY - endPosY;

        if (Mathf.Abs(xDisplacement) > (yDisplacement))
        {
            if (xDisplacement > 0)
            {
                Debug.Log("Right");
            }
            else
            {
                Debug.Log("Left");
            }
        }
        else
        {
            if (yDisplacement > 0)
            {
                Debug.Log("Up");
            }
            else
            {
                Debug.Log("Down");
            }
        }


    }
}
