using Script.MusicNote;
using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;

namespace Script.JudgePanel
{
    public partial struct JudgePanelSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            state.RequireForUpdate<BeginSimulationEntityCommandBufferSystem.Singleton>();
            state.RequireForUpdate<JudgePanelTag>();
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {

        }
        
        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            var ecb = SystemAPI.GetSingleton<BeginSimulationEntityCommandBufferSystem.Singleton>().CreateCommandBuffer(state.WorldUnmanaged);

            var judgePanelJob = new JudgePanelJob()
            {
                ECB = ecb.AsParallelWriter(),
            };
            state.Dependency = judgePanelJob.ScheduleParallel(state.Dependency);
        }
    }
}