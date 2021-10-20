using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Composter_ContentsReady : JavaBlockModel
    {
        public Composter_ContentsReady() : base("Composter Contents, Ready")
        {
            AddVersion("composter_contents_ready", "1.14")
                .WithPath("models/block")
                .AddTexture("inside", "block/composter_ready")
                .AddElement(element => {
                    element.From = new Vector3(2f, 0f, 2f);
                    element.To = new Vector3(14f, 15f, 14f);
                    element.FaceUp = new ModelFace("#inside");
                });
        }
    }
}
