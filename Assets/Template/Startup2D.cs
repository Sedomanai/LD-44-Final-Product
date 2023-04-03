using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Startup2D : MonoBehaviour
{
    [SerializeField]
    InputActionAsset map;
    [SerializeField]
    SpriteRenderer rend;

    public void EnablePlatformer() {
        map.FindActionMap("Platformer").Enable();
        rend.color = Color.cyan;
    }
}
