using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour {

    [SerializeField] private GameObject bullet;


    void Start()
    {

    }

    void Update()
    {
    }

    public void OnAttack(InputAction.CallbackContext context) {
        GameObject bulletInst = Instantiate(bullet, this.transform.position, Quaternion.identity);
    }
}
