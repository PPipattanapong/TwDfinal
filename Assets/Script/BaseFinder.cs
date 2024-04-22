using UnityEngine;

public class BaseFinder : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        GameObject baseObject = GameObject.FindWithTag("Base");

        if (baseObject != null)
        {
            //Find direction
            Vector3 direction = baseObject.transform.position - transform.position;

            Vector3 movement = direction.normalized * speed * Time.deltaTime;

            //Move to it
            transform.position += movement;
        }
    }
}
