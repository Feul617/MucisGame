using Unity.Entities;

namespace Script.JudgePanel
{
    public enum JudgeType
    {
        None,
        Miss,
        Bad,
        Good,
        Perfect,
    }
    
    public enum JudgeLine
    {
        First,
        Second,
        Third,
        Fourth,
        Fifth,
        Sixth,
    }

    public struct JudgePanelTag : IComponentData {}

    public struct JudgePanelAuthoring : IComponentData
    {
        public JudgeLine line;
    }
}