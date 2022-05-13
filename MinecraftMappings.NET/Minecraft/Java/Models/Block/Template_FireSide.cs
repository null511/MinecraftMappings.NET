using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_FireSide : JavaBlockModel
    {
        public Template_FireSide() : base("Template Fire, Side")
        {
            AddVersion("template_fire_side", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0.01f);
                    element.To = new Vector3(16f, 22.4f, 0.01f);
                    element.FaceNorth = new ModelFace("#fire", UVFull);
                    element.FaceSouth = new ModelFace("#fire", UVFull);
                });
        }
    }
}
