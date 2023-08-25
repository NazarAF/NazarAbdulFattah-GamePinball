using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{
    public Collider ball;
    public GameObject gate;
    public bool isOpen;

    private void OnTriggerEnter(Collider other) {
        if (other == ball) setGate();
    }

    public void setGate() {
        if (this.isOpen) Invoke("closeGate", 1);
        else openGate();
    }

    public void openGate() {
        this.gate.GetComponent<MeshRenderer>().enabled = false;
        this.gate.GetComponent<BoxCollider>().enabled = false;
        this.isOpen = !this.isOpen;
    }

    public void closeGate() {
        this.gate.GetComponent<MeshRenderer>().enabled = true;
        this.gate.GetComponent<BoxCollider>().enabled = true;
    }
}
