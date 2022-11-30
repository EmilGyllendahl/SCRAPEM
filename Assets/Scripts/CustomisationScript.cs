using UnityEngine;

public class CustomisationScript : MonoBehaviour
{
    public GameObject vehicle;
    public Weapons ws;
    public PlayerData pd;

    private void FixedUpdate()
    {
        vehicle.transform.Rotate(new Vector3(0,0.5f,0));
    }

    public void WeaponSelected(int index)
    {
        ws.SetWeapon(index);
        pd.index = index;
    }
}
