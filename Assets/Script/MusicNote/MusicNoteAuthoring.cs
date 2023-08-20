using Unity.Entities;

namespace Script.MusicNote
{
    public struct MusicNoteAuthoring : IComponentData
    {
        public MusicNoteInfo NoteInfo;
    }

    public struct MusicNoteTag : IComponentData { }
}