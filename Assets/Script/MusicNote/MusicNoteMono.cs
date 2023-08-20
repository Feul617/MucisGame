using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using Vector3 = System.Numerics.Vector3;

namespace Script.MusicNote
{
    public class MusicNoteMono : MonoBehaviour
    {
        public float noteSpeed;
    }

    public class MusicNoteBake : Baker<MusicNoteMono>
    {
        public override void Bake(MusicNoteMono authoring)
        {
            var entity = GetEntity(authoring, TransformUsageFlags.Dynamic);
            var noteInfo = new MusicNoteInfo()
            {
                NoteSpeed = authoring.noteSpeed,
            };
            AddComponent(entity, new MusicNoteAuthoring()
            {
                NoteInfo = noteInfo,
            });
        }
    }
}