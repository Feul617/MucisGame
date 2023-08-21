using Script.MusicNote;
using Unity.Entities;
using UnityEngine;

namespace Script.NoteGenerator
{
    public class NoteGenerator : MonoBehaviour
    {
        
    }
    
    public class NoteGeneratorBake : Baker<NoteGenerator>
    {
        public override void Bake(NoteGenerator authoring)
        {
            var entity = GetEntity(authoring, TransformUsageFlags.Dynamic);
            var noteInfo = new MusicNoteInfo
            {
                StartPosition = authoring.transform.position,
            };
        }
    }
}