using Unity.VisualScripting.FullSerializer;
using UnityEngine;

namespace Au
{
    /// <summary>
    /// Control System
    /// </summary>
    public class ControlSystem : MonoBehaviour
    {
        // SerializeField 私人變數顯示在面板
        // Header 變數標題
        // Range 變數範圍
        [SerializeField, Header("Moving Speed"), Range(1, 100)]
        private float moveSpeed = 3.5f;
        [SerializeField, Header("Jump Height"), Range(1, 100)]
        private float jumpHeight = 1.2f;

        Rigidbody2D Rig;
        private void Awake()
        {
            Rig = GetComponent<Rigidbody2D>();
        }

    }
}

