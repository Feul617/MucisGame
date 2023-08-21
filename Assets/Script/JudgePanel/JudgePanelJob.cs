using Script.Manager;
using Unity.Entities;
using UnityEngine;

namespace Script.JudgePanel
{
    public partial struct JudgePanelJob : IJobEntity
    {
        public EntityCommandBuffer.ParallelWriter ECB;
        
        public void Execute(JudgePanelAspect aspect, ManagerAspect managerAspect, [ChunkIndexInQuery]int sortKey)
        {

            switch (aspect.line)
            {
                case JudgeLine.First:
                    if (Input.GetKeyDown(KeyCode.D))
                        managerAspect._authoring.ValueRW.score += aspect.Judge();
                    break;
                case JudgeLine.Second:
                    if (Input.GetKeyDown(KeyCode.F))
                        managerAspect._authoring.ValueRW.score += aspect.Judge();
                    break;
                case JudgeLine.Third:
                    if (Input.GetKeyDown(KeyCode.J))
                        managerAspect._authoring.ValueRW.score += aspect.Judge();
                    break;
                case JudgeLine.Fourth:
                    if (Input.GetKeyDown(KeyCode.K))
                        managerAspect._authoring.ValueRW.score += aspect.Judge();
                    break;
            }
        }
    }
}