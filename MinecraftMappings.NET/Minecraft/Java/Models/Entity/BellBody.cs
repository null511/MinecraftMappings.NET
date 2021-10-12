using MinecraftMappings.Internal.Entities;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class BellBody : JavaEntityData
    {
        public BellBody() : base("Bell Body")
        {
            AddVersion("bell_body", "1.0.0")
                .WithPath("models/block/bell")
                .AddElement("top", element => {
                    element.Position = new Vector3(-3f, -7f, -3f);
                    element.Size = new Vector3(6f, 7f, 6f);
                    element.UV = Vector2.Zero;
                    element.TextureSize = new Vector2(32f, 32f);
                    element.RotationOrigin = new Vector3(0f, 1f, 0f);
                    element.RotationAngleX = 180;
                })
                .AddElement("bottom", element => {
                    element.Position = new Vector3(-4f, 0f, -4f);
                    element.Size = new Vector3(8f, 2f, 8f);
                    element.UV = new Vector2(0f, 13f);
                    element.TextureSize = new Vector2(32f, 32f);
                    element.RotationOrigin = new Vector3(0f, 1f, 0f);
                    element.RotationAngleX = 180;
                });
        }
    }
}
