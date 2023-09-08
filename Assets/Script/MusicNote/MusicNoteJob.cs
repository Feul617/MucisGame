using System.Runtime.InteropServices.ComTypes;
using Unity.Entities;
using Unity.Mathematics;

namespace Script.MusicNote
{
    public partial struct MusicNoteJob : IJobEntity
    {
        public EntityCommandBuffer.ParallelWriter ECB;
        public float DeltaTime;
        
        private void Execute(MusicNoteAspect aspect, [ChunkIndexInQuery]int sortKey)
        {
            
            aspect.Position -= new float3(0, aspect.NoteSpeed, 0);
        }
    }
}