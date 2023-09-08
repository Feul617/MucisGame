using Unity.Burst;
using Unity.Entities;

namespace Script.MusicNote
{
    public partial struct MusicNoteInitSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            var InitJob = new MusicNoteInitJob()
            {

            };
            state.Dependency = InitJob.Schedule(state.Dependency);
            state.Enabled = false;
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {

        }
    }
}