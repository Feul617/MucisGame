using System.Numerics;
using Unity.Mathematics;

namespace Script.MusicNote
{
    [System.Serializable]
    public enum MusicNodeType
    {
        Short,
        Long,
    }
    
    [System.Serializable]
    public enum MusicNodeLine
    {
        First,
        Second,
        Third,
        Fourth,
    }
    
    public struct MusicNoteInfo
    {
        public float3 StartPosition;
        public float3 EndPosition;
        public float LerpTime;
        public float NoteSpeed;

        public void SetStartPosition(float3 startPosition)
        {
            StartPosition = startPosition;
        }
    }
}