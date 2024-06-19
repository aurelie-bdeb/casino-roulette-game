using UnityEngine;

public class LeanTweenScale : MonoBehaviour
{

    public float _duration;
    public float _delay;

    private void Start()
    {
        var endScale = transform.localScale;
        transform.localScale = Vector3.zero;
        LeanTween.scale(gameObject, endScale, _duration)
                 .setDelay(_delay)
                 .setOnComplete(onComplete);
    }

    private void onComplete()
    {
        // Do on complete
    }
}
