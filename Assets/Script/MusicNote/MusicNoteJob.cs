using Unity.Entities;

namespace Script.MusicNote
{
    public partial struct MusicNoteJob : IJobEntity
    {
        public EntityCommandBuffer.ParallelWriter ECB;
        public float DeltaTime;
        
        private void Execute(MusicNoteAspect aspect, [ChunkIndexInQuery]int sortKey)
        {
            aspect.NoteFalling(DeltaTime);
        }
    }
}