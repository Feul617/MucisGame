using Unity.Entities;
using UnityEngine;

namespace Script.JudgePanel
{
    public partial struct JudgePanelJob : IJobEntity
    {
        public EntityCommandBuffer.ParallelWriter ECB;
        
        public void Execute(JudgePanelAspect aspect, [ChunkIndexInQuery]int sortKey)
        {
            switch (aspect.line)
            {
                //판정 -> 점수이므로 매니저에서 다시 만들어야함
                case JudgeLine.First:
                    if (Input.GetKeyDown(KeyCode.D))
                        aspect.Judge();
                    break;
                case JudgeLine.Second:
                    if (Input.GetKeyDown(KeyCode.F))
                        aspect.Judge();
                    break;
                case JudgeLine.Third:
                    if (Input.GetKeyDown(KeyCode.J))
                        aspect.Judge();
                    break;
                case JudgeLine.Fourth:
                    if (Input.GetKeyDown(KeyCode.K))
                        aspect.Judge();
                    break;
            }
        }
    }
}