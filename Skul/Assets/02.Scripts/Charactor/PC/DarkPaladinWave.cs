using Skul.Character.PC;
using UnityEngine;

public class DarkPaladinWave:PlayerProjectile
{
    protected override void Awake()
    {
        base.Awake();
    }

    public override void SetUp(GameObject owner, Vector2 velocity, float damage, LayerMask target)
    {
        base.SetUp(owner, velocity, damage, target);
    }

    protected override void Update()
    {
        base.Update();
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        
    }


    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
    }
}