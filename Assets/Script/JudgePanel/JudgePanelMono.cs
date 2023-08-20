using Script.MusicNote;
using Unity.Entities;
using UnityEngine;

namespace Script.JudgePanel
{

    public class JudgePanelMono : MonoBehaviour
    {
        public JudgeLine line;
    }

    public class JudgePanelBaker : Baker<JudgePanelMono>
    {
        public override void Bake(JudgePanelMono authoring)
        {
            var entity = GetEntity(authoring, TransformUsageFlags.Dynamic);
            AddComponent(entity, new JudgePanelAuthoring()
            {
                line = authoring.line,
            });
            var noteAuthoring = new MusicNoteAuthoring();
            //후에 generator의 위치로 변경
            var position = noteAuthoring.NoteInfo.StartPosition;
        }
    }
}