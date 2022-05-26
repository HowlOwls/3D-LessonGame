using System.Collections;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    private void Update()
    {
        StartCoroutine(MoveLeft());
    }

    private IEnumerator MoveLeft()
    {
        transform.position += Vector3.left * Time.deltaTime;
        yield return StartCoroutine(MoveRight());

    }

    private IEnumerator MoveRight()
    {
        transform.position += Vector3.right * Time.deltaTime;
        yield return StartCoroutine(MoveLeft());
    }
}
