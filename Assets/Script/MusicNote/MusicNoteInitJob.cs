using Unity.Entities;

namespace Script.MusicNote
{
    public partial struct MusicNoteInitJob : IJobEntity
    {
        public void Execute(MusicNoteAspect aspect, [ChunkIndexInQuery]int sortKey)
        {
            aspect.Position = aspect.StartPosition;
        }
    }
}