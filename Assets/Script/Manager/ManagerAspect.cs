using Script.JudgePanel;
using Unity.Entities;

namespace Script.Manager
{
    public readonly partial struct ManagerAspect : IAspect
    {
        public readonly Entity Entity;

        public readonly RefRW<ManagerAuthoring> _authoring;

        public int score => _authoring.ValueRO.score;
    }
}