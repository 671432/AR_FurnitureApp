using UnityEngine;
using Lean.Touch;

//create own cuz couldn't figure out new way of doing it
public class LeanSelectCustom : MonoBehaviour
{
    public LayerMask selectableLayer;

    void OnEnable()
    {
        LeanTouch.OnFingerTap += HandleFingerTap;
    }

    void OnDisable()
    {
        LeanTouch.OnFingerTap -= HandleFingerTap;
    }

    private void HandleFingerTap(LeanFinger finger)
    {
        Ray ray = Camera.main.ScreenPointToRay(finger.ScreenPosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, float.MaxValue, selectableLayer))
        {
            // Handle selection logic here
            Debug.Log("Tapped on: " + hit.collider.gameObject.name);
        }
    }
}