using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class SlimeGel : JavaEntityModel
    {
        public SlimeGel() : base("Slime Gel")
        {
            AddVersion("slime_gel", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("gel", element => {
                    element.Translate = new Vector3(0f, -4f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 0f, -4f),
                        Size = new Vector3(8f, 8f, 8f),
                    });
                });
        }
    }
}
