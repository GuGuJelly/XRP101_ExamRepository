using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerStatus _status;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        _status = GetComponent<PlayerStatus>();
    }

    private void Update()
    {
        MovePosition();
    }

    private void MovePosition()
    {
        Vector3 direction = Vector3.zero;
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        if (direction == Vector3.zero) return;

        // direction 벡터가 0이 아닐때, Normalize()를 써서 속도를 동일하게 만들어준다.
        // direction 벡터를 정규화하여, 무슨 방향으로 이동하든 이동하는 길이를 1로 만들어준다
        if (direction != Vector3.zero) direction.Normalize();

        transform.Translate(_status.MoveSpeed * Time.deltaTime * direction);
    }
}
