using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using static YSFramework.GlobalManager;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    protected Rigidbody2D rb;
    [SerializeField]
    protected Collider2D hitCol;
    /// <summary>
    /// ��ǰ���з���
    /// </summary>
    protected Vector2 direction;
    /// <summary>
    /// �����ٶȻ����������ٶȣ�����Ϊ1
    /// </summary>
    private float speed;
    /// <summary>
    /// ���̶�������Ͷ����
    /// </summary>
    /// <param name="start">��ʼ������</param>
    /// <param name="dir">����</param>
    /// <param name="speed">�䵯�����ٶ�</param>
    public virtual void Launch(Vector2 start, Vector2 dir, float speed, params object[] args)
    {
        transform.position = start;
        direction = dir.normalized;
        this.speed = speed;
    }
    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        hitCol = GetComponent<Collider2D>();
    }
    protected virtual void Update()
    {
        if (rb != null)
            rb.velocity = direction * speed;
    }
    protected virtual void OnTriggerEnter2D(Collider2D collider)
    {
        ObjPool.RecycleObject(gameObject);
    }
}