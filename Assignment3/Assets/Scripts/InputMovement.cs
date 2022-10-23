using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMovement : MonoBehaviour
{
    public PacStudentController pacStudentController { get; private set; }
    private KeyCode lastInput;

    void Awake()
    {
        this.pacStudentController = GetComponent<PacStudentController>();
    }

    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            this.pacStudentController.SetDir(Vector2.up);
            lastInput = KeyCode.W;
        }
        else if (Input.GetKeyDown("a"))
        {
            this.pacStudentController.SetDir(Vector2.left);
            lastInput = KeyCode.A;
        }
        else if (Input.GetKeyDown("d"))
        {
            this.pacStudentController.SetDir(Vector2.right);
            lastInput = KeyCode.D;
        }
        else if (Input.GetKeyDown("s"))
        {
            this.pacStudentController.SetDir(Vector2.down);
            lastInput = KeyCode.S;
        }


        float rotateAng = Mathf.Atan2(this.pacStudentController.dir.y, this.pacStudentController.dir.x);
        this.transform.rotation = Quaternion.AngleAxis(rotateAng * Mathf.Rad2Deg, Vector3.forward);
    }
}
