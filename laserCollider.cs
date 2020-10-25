// class setting up laser collider size and position at start

using UnityEngine;

public class LaserCollider : MonoBehaviour
{
    private Vector3 scale;
    private LaserDisplay laserDisplay;

    void Start()
    {
        laserDisplay = transform.parent.gameObject.GetComponent<LaserDisplay>();
        scale.x = laserDisplay.lineWidth;
        scale.y = scale.x;
        scale.z = laserDisplay.lineLength;
        transform.localScale = scale;
        transform.localPosition = new Vector3 (0,0,scale.z/2);
    }
}
