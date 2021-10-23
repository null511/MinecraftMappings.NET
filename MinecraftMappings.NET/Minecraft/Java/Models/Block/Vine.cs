using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Vine : JavaBlockModel
    {
        public Vine() : base("Vine")
        {
            AddVersion("vine", "1.0.0")
                .WithPath("models/block")
                .AddTexture("vine", "block/vine")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0.8f);
                    element.To = new Vector3(16f, 16f, 0.8f);
                    element.FaceNorth = new ModelFace("#vine") {
                        UV = UVMap(16f, 0f, 0f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#vine") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                });
        }
    }
}
