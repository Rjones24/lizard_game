using UnityEngine;

public class Eaten : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float adjustmentAngle = 0;
    public bool isapple = false;
    void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.tag == "Mouth")|| collision.gameObject.tag == "death")
        {
            Destroy(gameObject);
            Vector3 rotationInDeg = transform.eulerAngles;
            rotationInDeg.x += adjustmentAngle;
            Quaternion rotationInRad = Quaternion.Euler(rotationInDeg);
            if (isapple)
            {
                objectiveSystem.applesEaten += 1;
                objectiveSystem.applesRemaining -= 1;

            }
            else
            {
                objectiveSystem.MeatEaten+= 1;
                objectiveSystem.MeatRemaining -= 1;
            }
            Instantiate(prefabToSpawn, transform.position, rotationInRad);
            Debug.Log("nom nom nom");
        }
    }
}
