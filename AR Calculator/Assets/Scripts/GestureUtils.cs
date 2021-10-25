using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit.Input;

public class GestureUtils : MonoBehaviour
{
    [SerializeField] Calculator calculator = null;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        bool isPalm = HandJointUtils.TryGetJointPose(TrackedHandJoint.Palm, Handedness.Any, out MixedRealityPose palm);
        HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Any, out MixedRealityPose thumb);
        HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Any, out MixedRealityPose index);
        HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleTip, Handedness.Any, out MixedRealityPose middle);
        HandJointUtils.TryGetJointPose(TrackedHandJoint.RingTip, Handedness.Any, out MixedRealityPose ring);
        HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyTip, Handedness.Any, out MixedRealityPose pinky);

        if (isPalm) //&& 
        //    palm.Up == thumb.Up &&
        //    palm.Up == index.Up &&
        //    palm.Up == middle.Up &&
        //    palm.Up == ring.Up &&
        //    palm.Up == pinky.Up &&)
        {
            calculator.gameObject.SetActive(true);
        }
    }
}
