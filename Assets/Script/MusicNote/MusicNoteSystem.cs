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
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            var musicJob = new MusicNoteJob()
            {
                
            };
            //인자로 state.Dependency가 들어가는 이유는 R벨류에 L벨류를 넣어주기 때문에 state.Dependency + musicjob을 넣어주는 것
            state.Dependency = musicJob.Schedule(state.Dependency);
            
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {

        }
    }
}