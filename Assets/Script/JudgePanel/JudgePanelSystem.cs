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

            //태그를 갖고있는 여러 객체들을 관리할대는 뭘쓰는거지
            //var JudgePanelEntity = SystemAPI.GetSingletonEntity<JudgePanelTag>();
            //var JudgePanelAspect = SystemAPI.GetAspect<JudgePanelAspect>(JudgePanelEntity);

            //var nearPistolNodeAspect = SystemAPI.GetAspect<MusicNoteAspect>();
        }
    }
}