using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Enderman : JavaEntityModel
    {
        public Enderman() : base("Enderman")
        {
            AddVersion("enderman", "1.8")
                //.WithPath("entity/enderman")
                .WithTextureSize(64, 32)
                .AddElement("head", element => {
                    element.Position = new Vector3(-4f, 39f, -4f);
                    element.Size = new Vector3(8f, 8f, 8f);
                    element.UV = new Vector2(0f, 0f);
                    element.RotationOrigin = new Vector3(0f, 39f, 0f);
                })
                .AddElement("headwear", element => {
                    element.Position = new Vector3(-4f, 39f, -4f);
                    element.Size = new Vector3(8f, 8f, 8f);
                    element.UV = new Vector2(0f, 16f);
                    element.RotationOrigin = new Vector3(0f, 39f, 0f);
                    element.Inflate = -0.5f;
                })
                .AddElement("body", element => {
                    element.Position = new Vector3(-4f, 27f, -2f);
                    element.Size = new Vector3(8f, 12f, 4f);
                    element.UV = new Vector2(32f, 16f);
                    element.RotationOrigin = new Vector3(0f, 39f, 0f);
                })
                .AddElement("right_arm", element => {
                    element.Position = new Vector3(4f, 9f, -1f);
                    element.Size = new Vector3(2f, 30f, 2f);
                    element.UV = new Vector2(56f, 0f);
                    element.RotationOrigin = new Vector3(-5f, 37f, 0f);
                })
                .AddElement("left_arm", element => {
                    element.Position = new Vector3(-6f, 9f, -1f);
                    element.Size = new Vector3(2f, 30f, 2f);
                    element.UV = new Vector2(56f, 0f);
                    element.RotationOrigin = new Vector3(5f, 37f, 0f);
                })
                .AddElement("right_leg", element => {
                    element.Position = new Vector3(1f, 0f, -1f);
                    element.Size = new Vector3(2f, 30f, 2f);
                    element.UV = new Vector2(56f, 0f);
                    element.RotationOrigin = new Vector3(-2f, 30f, 0f);
                })
                .AddElement("left_leg", element => {
                    element.Position = new Vector3(-3f, 0f, -1f);
                    element.Size = new Vector3(2f, 30f, 2f);
                    element.UV = new Vector2(56f, 0f);
                    element.RotationOrigin = new Vector3(2f, 30f, 0f);
                });
        }
    }
}
