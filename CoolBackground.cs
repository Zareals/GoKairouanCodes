using UnityEngine;

public class CoolBackground : MonoBehaviour
{
    Vector2 startPos;
    [SerializeField]
    int moveModifier;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        Vector2 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        float posX = Mathf.Lerp(transform.position.x, startPos.x + (pos.x * moveModifier), 2f * Time.deltaTime);
        float posY = Mathf.Lerp(transform.position.y, startPos.y + (pos.y * moveModifier), 2f * Time.deltaTime);

        transform.position = new Vector3(posX, posY, 0);
    }
}
