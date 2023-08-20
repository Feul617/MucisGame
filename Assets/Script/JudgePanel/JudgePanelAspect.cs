using Script.MusicNote;
using Unity.Entities;
using Unity.Transforms;

namespace Script.JudgePanel
{
    public readonly partial struct JudgePanelAspect : IAspect
    {
        public readonly Entity Entity;

        public readonly RefRW<LocalTransform> Transform;
        private readonly RefRW<JudgePanelAuthoring> _authoring;
        private readonly RefRW<MusicNoteAuthoring> _noteAuthoring;

        public float JudgeInterval => _noteAuthoring.ValueRO.NoteInfo.LerpTime;
        public JudgeLine line => _authoring.ValueRO.line;
        
        public JudgeType Judge()
        {
            if (JudgeInterval is < 0.95f and > 0.85f) return JudgeType.Perfect;
            if (JudgeInterval is < 0.85f and > 0.75f) return JudgeType.Good;
            if (JudgeInterval is < 0.75f and > 0.65f) return JudgeType.Bad;
            return JudgeType.Miss;
        }
    }
}