using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMove : MonoBehaviour
{
    public float speed = 5f;
    public float steerSpeed = 180f;
    public int Gap = 10;
    public float bodySpeed = 5;

    public GameObject bodyPrefab;
    private List<GameObject> BodyParts = new List<GameObject>();
    private List<Vector3> PositionHistory = new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        Grow();
        Grow();
        Grow();
        Grow();
        Grow();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        float steerDirection = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * steerSpeed * steerDirection * Time.deltaTime);

        PositionHistory.Insert(0, transform.position);

        int index = 0;
        foreach (var body in BodyParts)
        {
            Vector3 point = PositionHistory[Mathf.Min(index * Gap, PositionHistory.Count - 1)];
            Vector3 moveDirection = point - body.transform.position;
            body.transform.position += moveDirection * bodySpeed * Time.deltaTime;
            body.transform.LookAt(point);
            index++;
        }
    }

    private void Grow()
    {
        GameObject body = Instantiate(bodyPrefab);
        BodyParts.Add(body);
    }
}
