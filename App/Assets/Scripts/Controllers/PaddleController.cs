using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
	public KeyCode input;
	public float springPower;

	private HingeJoint hinge;

	private void Start()
    {
        this.hinge = GetComponent<HingeJoint>();
    }

	private void Update() {
        ReadInput();
    }

    private void ReadInput() {
        JointSpring jointSpring = this.hinge.spring;

        if (Input.GetKey(input)) jointSpring.spring = springPower;
        else jointSpring.spring = 0;

        this.hinge.spring = jointSpring;
    }
}
