using Script.JudgePanel;
using Script.MusicNote;
using Unity.Entities;

namespace Script.Manager
{
    public struct ManagerAuthoring : IComponentData
    {
        public MusicNoteAuthoring MusicAuthoring;
        public JudgePanelAuthoring PanelAuthoring;

        public int score;
        
    }
}