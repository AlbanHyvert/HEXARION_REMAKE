public interface ITurrets
{
    void Init(TurretsAI self = null, Projectile projectile = null);

    void Enter();

    void Tick();

    void Exit();
}
