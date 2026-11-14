using UnityEngine;
using UnityEngine.InputSystem;

public class ClickOff : MonoBehaviour
{
    public void OnAttack(InputAction.CallbackContext ctx)
    {
        if(ctx.performed)
        {
            if (this.gameObject.activeInHierarchy)
            {
                this.gameObject.SetActive(false);
            }
        }
    }
}
