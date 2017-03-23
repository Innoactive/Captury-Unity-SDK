using System;

namespace Captury
{
    [Serializable]
    public class CapturyConfig
    {
        [Serializable]
        public class HeadsetARTag
        {
            /// <summary>
            /// id of the AR tag which is attached to the headset
            /// </summary>
            public int id;

            /// <summary>
            /// y rotation of the AR Tag when headset points forward
            /// </summary>
            public float offsetHeadsetRotY;

            public HeadsetARTag(int id)
            {
                this.id = id;
            }
        }

        /// <summary>
        /// array of ar tags which are attached to the headset
        /// </summary>
        public HeadsetARTag[] headsetARTags;

        /// <summary>
        /// Avatar ID which is assigned to the local user
        /// </summary>
        public int avatarID;

        /// <summary>
        /// Captury Live host
        /// </summary>
        public string host;

        /// <summary>
        /// Captury Live port
        /// </summary>
        public ushort port;

        /// <summary>
        /// Timeout in ms for checking new actors
        /// </summary>
        public int actorCheckTimeout;

        /// <summary>
        /// Captury Live avatar scale factor
        /// </summary>
        public float scaleFactor;

        /// <summary>
        /// if true AR tags will be streamed from Captury Live
        /// </summary>
        public bool streamARTags;

        /// <summary>
        /// if true AR tags will be displayed as smal plates
        /// </summary>
        public bool debugARTags;

        /// <summary>
        /// Distance threshold (in meter) for user assignment with AR Tag
        /// </summary>
        public float arTagSkeletonThreshold;

        /// <summary>
        /// Smoothing factor for the head positon
        /// Higher value means faster camera movement but more jittering
        /// </summary>
        public float headPositionSmoothing;

        /// <summary>
        /// Smoothing factor for the rotational drift correction with AR tags
        /// Higher value means higher impact of the AR tag
        /// </summary>
        public float yRotDriftCorrectionSmoothing;

        /// <summary>
        /// The number of frames which should be considered for AR Tag tracking improvement
        /// </summary>
        public int maxARTagSamples;

        /// <summary>
        /// Offset from head to center eye
        /// </summary>
        public float headToCenterEyeOffsetX;
        public float headToCenterEyeOffsetY;
        public float headToCenterEyeOffsetZ;
    }
}
