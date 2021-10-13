using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Cow : JavaEntityModel
    {
        public Cow() : base("Cow")
        {
            AddVersion("cow", "1.0.0")
                .WithPath("block/cow")
                .AddElement("body", element => {
                    element.Position = new Vector3(-6f, 11f, -5f);
                    element.Size = new Vector3(12f, 18f, 10f);
                    element.UV = new Vector2(18f, 4f);
                    element.TextureSize = new Vector2(64f, 32f);
                    element.RotationOrigin = new Vector3(0f, 19f, 2f);
                    element.RotationAngleX = 270;
                })
                .AddElement("utter", element => {
                    element.Position = new Vector3(-2f, 11f, -6f);
                    element.Size = new Vector3(4f, 6f, 1f);
                    element.UV = new Vector2(52f, 0f);
                    element.TextureSize = new Vector2(64f, 32f);
                    element.RotationOrigin = new Vector3(0f, 19f, 2f);
                    element.RotationAngleX = 270;
                })
                .AddElement("head", element => {
                    element.Position = new Vector3(-4f, 16f, -14f);
                    element.Size = new Vector3(8f, 8f, 6f);
                    element.UV = new Vector2(0f, 0f);
                    element.TextureSize = new Vector2(64f, 32f);
                    element.RotationOrigin = new Vector3(0f, 20f, -8f);
                })
                .AddElement("left_horn", element => {
                    element.Position = new Vector3(-5f, 22f, -12f);
                    element.Size = new Vector3(1f, 3f, 1f);
                    element.UV = new Vector2(22f, 0f);
                    element.TextureSize = new Vector2(64f, 32f);
                    element.RotationOrigin = new Vector3(0f, 20f, -8f);
                })
                .AddElement("right_horn", element => {
                    element.Position = new Vector3(4f, 22f, -12f);
                    element.Size = new Vector3(1f, 3f, 1f);
                    element.UV = new Vector2(22f, 0f);
                    element.TextureSize = new Vector2(64f, 32f);
                    element.RotationOrigin = new Vector3(0f, 20f, -8f);
                })
                .AddElement("leg1", element => {
                    element.Position = new Vector3(2f, 0f, 5f);
                    element.Size = new Vector3(4f, 12f, 4f);
                    element.UV = new Vector2(0f, 16f);
                    element.TextureSize = new Vector2(64f, 32f);
                    element.RotationOrigin = new Vector3(-4f, 12f, 7f);
                })
                .AddElement("leg2", element => {
                    element.Position = new Vector3(-6f, 0f, 5f);
                    element.Size = new Vector3(4f, 12f, 4f);
                    element.UV = new Vector2(0f, 16f);
                    element.TextureSize = new Vector2(64f, 32f);
                    element.RotationOrigin = new Vector3(4f, 12f, 7f);
                })
                .AddElement("leg3", element => {
                    element.Position = new Vector3(2f, 0f, -7f);
                    element.Size = new Vector3(4f, 12f, 4f);
                    element.UV = new Vector2(0f, 16f);
                    element.TextureSize = new Vector2(64f, 32f);
                    element.RotationOrigin = new Vector3(-4f, 12f, -6f);
                })
                .AddElement("leg4", element => {
                    element.Position = new Vector3(-6f, 0f, -7f);
                    element.Size = new Vector3(4f, 12f, 4f);
                    element.UV = new Vector2(0f, 16f);
                    element.TextureSize = new Vector2(64f, 32f);
                    element.RotationOrigin = new Vector3(4f, 12f, -6f);
                });
        }
    }
}
