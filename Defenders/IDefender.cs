using Enemies;

namespace Defenders
{
    interface IDefender
    {
        int Attack(Skeleton enemy);
        int Attack(Orc enemy);
        int Attack(Elemental enemy);
    }
}