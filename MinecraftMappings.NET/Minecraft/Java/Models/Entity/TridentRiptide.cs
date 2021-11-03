using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class TridentRiptide : JavaEntityModel
    {
        public TridentRiptide() : base("Trident Riptide")
        {
            AddVersion("trident_riptide", "1.0.0")
                .WithTextureSize(64, 64)
                .AddElement("body", element => {
                    element.Translate = new Vector3(0f, -15.5f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-8f, 0f, -8f),
                        Size = new Vector3(16f, 31f, 16f),
                    });
                });
        }
    }
}
