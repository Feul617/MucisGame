using Script.MusicNote;
using Unity.Burst;
using Unity.Entities;

namespace Script.NoteGenerator
{
    public partial struct NoteGeneratorSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            state.RequireForUpdate<MusicNoteTag>();
            state.RequireForUpdate<BeginSimulationEntityCommandBufferSystem.Singleton>();
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            var ecb = SystemAPI.GetSingleton<BeginSimulationEntityCommandBufferSystem.Singleton>().CreateCommandBuffer(state.WorldUnmanaged);

            /*var NoteGeneratorjob = new NoteGeneratorJob()
            {
                ECB = ecb.AsParallelWriter(),
                
            }*/
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {

        }
    }
    
    public partial struct NoteGeneratorJob : IJobEntity
    {
        public EntityCommandBuffer.ParallelWriter ECB;

        private void Execute()
        {
            
        }
    }
}