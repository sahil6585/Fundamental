using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject cubePrefab;
    public int rowCount = 3;
    public float spacing = 1.5f;

    void Start()
    {
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < rowCount; j++)
            {
                // Calculate position for each cube
                Vector3 position = new Vector3(i * spacing, 0f, j * spacing);
                // Instantiate cube at the calculated position
                Instantiate(cubePrefab, position, Quaternion.identity);
            }
        }
    }
}
