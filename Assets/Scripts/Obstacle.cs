using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;

    void Update(){
        transform.position += ((Vector3.left * speed) * Time.deltaTime);
    }
}
