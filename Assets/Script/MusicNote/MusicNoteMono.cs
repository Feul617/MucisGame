using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using Vector3 = System.Numerics.Vector3;

namespace Script.MusicNote
{
    public class MusicNoteMono : MonoBehaviour
    {
        public float noteSpeed;
        public float3 startPosition;
    }

    public class MusicNoteBake : Baker<MusicNoteMono>
    {
        public override void Bake(MusicNoteMono authoring)
        {
            var entity = GetEntity(authoring, TransformUsageFlags.Dynamic);
            //mono로 inspect창에서 입력한 노트 스피드를 noteinfo로 이동
            var noteInfo = new MusicNoteInfo()
            {
                NoteSpeed = authoring.noteSpeed,
                StartPosition = authoring.startPosition,
            };
            AddComponent<MusicNoteTag>(entity);
            AddComponent(entity, new MusicNoteAuthoring()
            {
                NoteInfo = noteInfo,
            });
        }
    }
}