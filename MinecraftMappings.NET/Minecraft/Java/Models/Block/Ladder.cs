using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Ladder : JavaBlockModel
    {
        public Ladder() : base("Ladder")
        {
            AddVersion("ladder", "1.0.0")
                .WithPath("models/block")
                .AddTexture("texture", "block/ladder")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 15.2f);
                    element.To = new Vector3(16f, 16f, 15.2f);
                    element.FaceNorth = new ModelFace("#texture", UVFull);
                    element.FaceSouth = new ModelFace("#texture") {
                        UV = UVMap(16f, 0f, 0f, 16f),
                    };
                });
        }
    }
}
