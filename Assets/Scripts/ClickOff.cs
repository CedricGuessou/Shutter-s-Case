using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ClickOff : MonoBehaviour
{
    [SerializeField] private Vertices vertex;

    public void OnAttack(InputAction.CallbackContext ctx)
    {
        if(ctx.performed)
        {
            if (this.gameObject.activeInHierarchy)
            {
                vertex.CurrentScene = Vertices.VerticesScene.desk;
                this.gameObject.GetComponent<Image>().enabled = false;
            }
        }
    }
}
