using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Composter_Contents2 : JavaBlockModel
    {
        public Composter_Contents2() : base("Composter Contents, 2")
        {
            AddVersion("composter_contents2", "1.14")
                .WithPath("models/block")
                .AddTexture("inside", "block/composter_compost")
                .AddElement(element => {
                    element.From = new Vector3(2f, 0f, 2f);
                    element.To = new Vector3(14f, 5f, 14f);
                    element.FaceUp = new ModelFace("#inside");
                });
        }
    }
}
