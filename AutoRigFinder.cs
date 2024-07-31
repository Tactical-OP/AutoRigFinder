using UnityEngine;
using UnityEditor;

public class AutoRigFinder : MonoBehaviour
{
    public Transform head;
    public Transform leftHand;
    public Transform rightHand;
    public Transform leftFoot;
    public Transform rightFoot;

    [ContextMenu("Auto Find")]
    public void AutoFind()
    {
        Animator animator = GetComponent<Animator>();

        if (animator != null)
        {
            head = animator.GetBoneTransform(HumanBodyBones.Head);
            leftHand = animator.GetBoneTransform(HumanBodyBones.LeftHand);
            rightHand = animator.GetBoneTransform(HumanBodyBones.RightHand);
            leftFoot = animator.GetBoneTransform(HumanBodyBones.LeftFoot);
            rightFoot = animator.GetBoneTransform(HumanBodyBones.RightFoot);
        }
        else
        {
            Debug.LogWarning("No Animator component found!");
        }
    }
}

[CustomEditor(typeof(AutoRigFinder))]
public class AutoRigFinderEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        AutoRigFinder script = (AutoRigFinder)target;
        if (GUILayout.Button("Auto Find"))
        {
            script.AutoFind();
        }
    }
}
