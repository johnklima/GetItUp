using UnityEngine;

public class AudioManipulate : MonoBehaviour
{
    public FMODUnity.StudioEventEmitter emitter;
    public float moveA = 0.0f;
    public float moveB = 0.0f;
    private void Update()
    {
        emitter.SetParameter("Marker A", moveA);
        emitter.SetParameter("Marker B", moveB);

    }
}
