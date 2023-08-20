using Unity.Burst;
using Unity.Entities;
using Unity.VisualScripting;

namespace Script.MusicNote
{
    public partial struct MusicNoteSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            state.RequireForUpdate<BeginSimulationEntityCommandBufferSystem.Singleton>();
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            var ecb = SystemAPI.GetSingleton<BeginSimulationEntityCommandBufferSystem.Singleton>().CreateCommandBuffer(state.WorldUnmanaged);

            var musicNoteJob = new MusicNoteJob()
            {
                ECB = ecb.AsParallelWriter(),
                DeltaTime = SystemAPI.Time.DeltaTime,
            };
            state.Dependency = musicNoteJob.ScheduleParallel(state.Dependency);
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {

        }
    }
}