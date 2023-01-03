using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    // jump location support
    const float MinX = -8;
    const float MaxX = 8;
    const float MinY = -4;
    const float MaxY = 4;

    // timer support
    const float totalJumpDelaySeconds = 0.1f;
    float elapsedJumpDelaySeconds = 0;

    // Start is called when the object is created
    void Start()
    {
        Vector2 scale = transform.localScale;

        scale.x *= 3;
        scale.y *= 3;

        transform.localScale = scale;
    }

    // Update is called once per frame
    void Update()
    {
        // update timer and check if it's done
        elapsedJumpDelaySeconds += Time.deltaTime;

        if (elapsedJumpDelaySeconds >= totalJumpDelaySeconds)
        {
            elapsedJumpDelaySeconds = 0;

            Vector2 position = transform.position;

            position.x = Random.Range(MinX, MaxX);
            position.y = Random.Range(MinY, MaxY);

            transform.position = position;
        }
    }
}
