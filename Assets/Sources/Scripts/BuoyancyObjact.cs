using UnityEngine;

//////////////////////////
//   Kristofer Ledoux   //
// Copyright &copy 2022 //
//////////////////////////

namespace FroggyJump
{
    [RequireComponent(typeof(Rigidbody))]
    public class BuoyancyObjact : MonoBehaviour
    {
        private Rigidbody rb;

        [SerializeField]
        private float waterHeight = 0f;
        [SerializeField]
        private float underWaterDrag = 3f;
        [SerializeField]
        private float underWaterAngularDrag = 1f;
        [SerializeField]
        private float airDrag = 0f;
        [SerializeField]
        private float airAngularDrag = 0.05f;

        [SerializeField]
        private float floatingForce = 0f;

        bool underWater;

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {

            float diff = transform.position.y - waterHeight;

            if (diff < 0)
            {
                rb.AddForceAtPosition(Vector3.up * floatingForce * Mathf.Abs(diff), transform.position, ForceMode.Force);
                if (!underWater)
                {
                    underWater = true;
                    SwitchState(underWater);
                }
            }
            else if (underWater)
            {
                underWater = false;
            }
        }

        void SwitchState(bool isUnderWater)
        {
            if (isUnderWater)
            {
                rb.drag = underWaterDrag;
                rb.angularDrag = underWaterAngularDrag;
            }
            else
            {
                rb.drag = airDrag;
                rb.angularDrag = airAngularDrag;
            }
        }
    }
}