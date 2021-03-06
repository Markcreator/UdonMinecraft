
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

// Helper class for modifying blocks in the Unity editor
public class BlockModifier : UdonSharpBehaviour
{
    [SerializeField] WorldGenerator generator;
    [SerializeField] Vector3 targetBlock;
    [SerializeField] byte blockType;

    override public void Interact()
    {
        generator.addBlock((byte) Mathf.FloorToInt(targetBlock.x), (byte) Mathf.FloorToInt(targetBlock.y), (byte) Mathf.FloorToInt(targetBlock.z), blockType);
    }
}
