using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers {
    public class LauncherController : MonoBehaviour {
        private Collision collision = new Collision();
        public Collider ball;
        public KeyCode input;

        public float maxTimeHold;
        public float maxForce;
        private bool isHold;

        private float[] localScale = new float[3];

        private void Start() {
            this.isHold = false;
            this.localScale[0] = transform.localScale.x;
            this.localScale[1] = transform.localScale.y;
            this.localScale[2] = transform.localScale.z;
        }

        // private void Update() {
        //     this.OnCollisionStay(this.collision);
        // }

        private void OnCollisionStay(Collision collision) {
            if (collision.collider == this.ball) ReadInput(this.ball);
        }

        private void ReadInput(Collider collider) {
            if (Input.GetKey(this.input) && !this.isHold) StartCoroutine(StartHold(collider));
        }

        private IEnumerator StartHold(Collider collider) {
            this.isHold     = !this.isHold;
            float force     = 0.0f;
            float timeHold  = 0.0f;

            while (Input.GetKey(input)) {
                force = Mathf.Lerp(0, this.maxForce, timeHold / this.maxTimeHold);
                yield return new WaitForEndOfFrame();
                timeHold += Time.deltaTime;
                transform.localScale = new Vector3(localScale[0], localScale[1], 2);
                if(timeHold >= this.maxTimeHold || transform.localScale.x <= 0) break;
            }

            collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
            transform.localScale = new Vector3(localScale[0], localScale[1], localScale[2]);
            this.isHold     = !this.isHold;
        }
    }
}
