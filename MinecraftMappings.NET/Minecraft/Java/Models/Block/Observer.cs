using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Observer : JavaBlockModel
    {
        public Observer() : base("Observer")
        {
            AddVersion("observer", "1.11")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("top", "block/observer_top")
                .AddTexture("bottom", "block/observer_back")
                .AddTexture("front", "block/observer_front")
                .AddTexture("side", "block/observer_side")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace("#top") {
                        UV = UVMap(0f, 16f, 16f, 0f),
                    };
                    element.FaceDown = new ModelFace("#top", UVFull);
                    element.FaceNorth = new ModelFace("#front", UVFull);
                    element.FaceSouth = new ModelFace("#bottom", UVFull);
                    element.FaceWest = new ModelFace("#side", UVFull);
                    element.FaceEast = new ModelFace("#side", UVFull);
                });
        }
    }
}
