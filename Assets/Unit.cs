
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    protected int Damage;
    protected int Speed;

    public abstract void Cry();

    public void initialize(int damage, int speed)
    {
        Damage = damage;
        Speed = speed;
    }
    
    public void SpawnTo()
    {
        Vector2 randomPoint = Random.insideUnitCircle * 3;
        transform.position = new Vector3(randomPoint.x,0, randomPoint.y);
    }
}
