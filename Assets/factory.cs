
using UnityEngine;

public class Factory :
MonoBehaviour

{
    // ���� ��� �������� ���/���� �������� �������������
    [
SerializeField
]
    private int _minDamage = 5, _maxDamage = 30;
    [
SerializeField
]
    private int _minSpeed = 1, _maxSpeed = 10;
    // ���� ��� �������� ����� ������
    [
SerializeField
]
    private Transform _spawnPoint;

    // ����� ��� �������� �����
    public void Create(Unit unit)
    {
        // �������� �����
        Unit instance =
Instantiate
(unit);
        // ������������ ������ �������������
        instance.initialize(
                 Random.
Range
(_minDamage, _maxDamage),
                 Random.
Range
(_minSpeed, _maxSpeed));
        // ����� ����� � ��������� �����
        instance.
SpawnTo
(_spawnPoint.
position
);
        // ������ ���� �����
        instance.
Cry
();
    }
}