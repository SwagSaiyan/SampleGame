
using UnityEngine;

public class Factory :
MonoBehaviour

{
    // Поля для хранения мин/макс значений характеристик
    [
SerializeField
]
    private int _minDamage = 5, _maxDamage = 30;
    [
SerializeField
]
    private int _minSpeed = 1, _maxSpeed = 10;
    // Поле для хранения точки спавна
    [
SerializeField
]
    private Transform _spawnPoint;

    // Метод для создания Юнита
    public void Create(Unit unit)
    {
        // Создание юнита
        Unit instance =
Instantiate
(unit);
        // Присваивание юнитам характеристик
        instance.initialize(
                 Random.
Range
(_minDamage, _maxDamage),
                 Random.
Range
(_minSpeed, _maxSpeed));
        // Спавн юнита в рандомной точке
        instance.
SpawnTo
(_spawnPoint.
position
);
        // Боевой клич юнита
        instance.
Cry
();
    }
}