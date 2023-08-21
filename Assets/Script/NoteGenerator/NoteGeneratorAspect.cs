using Unity.Entities;
using Unity.Transforms;

namespace Script.NoteGenerator
{
    public readonly partial struct NoteGeneratorAspect : IAspect
    {
        public readonly Entity Entity;

        public readonly RefRW<LocalTransform> Transform;
        private readonly RefRW<NoteGeneratorAuthoring> _authoring;
    }
}