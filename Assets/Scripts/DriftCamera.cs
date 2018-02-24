using System;
using UnityEngine;

public class DriftCamera : MonoBehaviour
{
    [Serializable]
    public class AdvancedOptions
    {
        public bool updateCameraInUpdate;
        public bool updateCameraInFixedUpdate = true;
        public bool updateCameraInLateUpdate;
        public KeyCode switchViewKey = KeyCode.Space;
    }

    public float smoothing = 6f;
    public Transform lookAtTarget;
    public Transform positionTarget;
    public Transform sideView;
    public AdvancedOptions advancedOptions;

	bool firstPerson = GameManager.firstPerson;

	void Start () {
		if (!firstPerson)
		{
			transform.position = sideView.position;
			transform.rotation = sideView.rotation;
		}
		else
		{
			transform.position = Vector3.Lerp(transform.position, positionTarget.position, Time.deltaTime * smoothing);
			transform.LookAt(lookAtTarget);
		}
	}

//    private void FixedUpdate ()
//    {
//        if(advancedOptions.updateCameraInFixedUpdate)
//            UpdateCamera ();
//    }
//
//    private void Update ()
//    {
//        if (Input.GetKeyDown (advancedOptions.switchViewKey))
//            firstPerson = !firstPerson;
//
//        if(advancedOptions.updateCameraInUpdate)
//            UpdateCamera ();
//    }
//
//    private void LateUpdate ()
//    {
//        if(advancedOptions.updateCameraInLateUpdate)
//            UpdateCamera ();
//    }
//
//    private void UpdateCamera ()
//    {
//        if (firstPerson)
//        {
//            transform.position = sideView.position;
//            transform.rotation = sideView.rotation;
//        }
//        else
//        {
//            transform.position = Vector3.Lerp(transform.position, positionTarget.position, Time.deltaTime * smoothing);
//            transform.LookAt(lookAtTarget);
//        }
//    }
}
