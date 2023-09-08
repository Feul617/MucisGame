using System.Numerics;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

namespace Script.MusicNote
{
    public readonly partial struct MusicNoteAspect : IAspect
    {
        public readonly Entity Entity;

        public readonly RefRO<MusicNoteTag> _Tag;

        public readonly RefRW<LocalTransform> Transform;
        public readonly RefRW<MusicNoteAuthoring> MusicNodeAuthoring;

        public float3 StartPosition => MusicNodeAuthoring.ValueRO.NoteInfo.StartPosition;
        public float3 EndPosition => MusicNodeAuthoring.ValueRO.NoteInfo.EndPosition;
        //nodeinfo로 이동된 notespeed를 aspect에 넣어줌
        public float NoteSpeed => MusicNodeAuthoring.ValueRO.NoteInfo.NoteSpeed;

        public float3 Position
        {
            get => Transform.ValueRO.Position;
            set => Transform.ValueRW.Position = value;
        }

        public float LerpTime
        {
            get => MusicNodeAuthoring.ValueRO.NoteInfo.LerpTime;
            set => MusicNodeAuthoring.ValueRW.NoteInfo.LerpTime = value;
        }

        public void NoteFalling(float deltaTime)
        {
            LerpTime += deltaTime * NoteSpeed;
            Transform.ValueRW.Position = math.lerp(StartPosition, EndPosition, LerpTime) * (StartPosition - EndPosition);
        }
    }
}