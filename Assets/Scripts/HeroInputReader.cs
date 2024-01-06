using UnityEngine;
using UnityEngine.InputSystem;


public class HeroInputReader : MonoBehaviour
{
    [SerializeField] private Hero _hero;

    public void OnMovement(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector3>();
        _hero.SetDirection(direction);
    } 

}
