using UnityEngine;

public class LaserCollision : MonoBehaviour
{
    private Vector3 scale;
    private LaserDisplay laserDisplay;

    public GameObject ExplosionPrefab;

    void Start()
    {
        laserDisplay = transform.parent.gameObject.GetComponent<LaserDisplay>();
        scale.x = laserDisplay.lineWidth;
        scale.y = scale.x;
        scale.z = laserDisplay.lineLength;
        transform.localScale = scale;
        transform.localPosition = new Vector3 (0,0,scale.z/2);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "ThirdPersonController")
        {
            GameObject explosion = Instantiate(ExplosionPrefab, transform.parent.position, transform.parent.rotation);
            Destroy(explosion, 1);
        }
    }
}
