using UnityEngine;

public class MovementFirstCar : MonoBehaviour
{
    public GameObject canvasFirst, secondCar,secondCanvas;
    private bool isFirst;
    private CarController _controller;

    private void Start()
    {
        _controller = GetComponent<CarController>();
    }

    private void Update()
    {
        if (transform.position.x < 8f && !isFirst) {
            _controller.speed = 0;
            canvasFirst.SetActive(true);
            isFirst = true;
        }
    }

    private void OnMouseDown()
    {
        if (!isFirst || transform.position.x>9f) return;
        _controller.speed = 15f;
        canvasFirst.SetActive(false);
        secondCanvas.SetActive(true);

        secondCar.GetComponent<CarController>().speed = 12f;
    }

}
