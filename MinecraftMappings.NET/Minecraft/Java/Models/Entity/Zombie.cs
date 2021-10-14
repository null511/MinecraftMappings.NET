using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Zombie : JavaEntityModel
    {
        public Zombie() : base("Zombie")
        {
            AddVersion("zombie", "1.0.0")
                //.WithPath("entity/zombie")
                .WithTextureSize(64, 64)
                .AddElement("head", element => {
                    element.Position = new Vector3(-4f, 24f, -4f);
                    element.Size = new Vector3(8f, 8f, 8f);
                    element.UV = Vector2.Zero;
                    element.RotationOrigin = new Vector3(0f, 24f, 0f);
                })
                .AddElement("headwear", element => {
                    element.Position = new Vector3(-4f, 24f, -4f);
                    element.Size = new Vector3(8f, 8f, 8f);
                    element.Inflate = 0.25f;
                    element.UV = new Vector2(32f, 0f);
                    element.RotationOrigin = new Vector3(0f, 24f, 0f);
                })
                .AddElement("body", element => {
                    element.Position = new Vector3(-4f, 12f, -2f);
                    element.Size = new Vector3(8f, 12f, 4f);
                    element.UV = new Vector2(16f, 16f);
                    element.RotationOrigin = new Vector3(0f, 24f, 0f);
                })
                .AddElement("left_arm", element => {
                    element.Position = new Vector3(-8f, 12f, -2f);
                    element.Size = new Vector3(4f, 12f, 4f);
                    element.UV = new Vector2(40f, 16f);
                    element.RotationOrigin = new Vector3(5f, 22f, 0f);
                })
                .AddElement("right_arm", element => {
                    element.Position = new Vector3(4f, 12f, -2f);
                    element.Size = new Vector3(4f, 12f, 4f);
                    element.UV = new Vector2(40f, 16f);
                    element.RotationOrigin = new Vector3(-5f, 22f, 0f);
                })
                .AddElement("left_leg", element => {
                    element.Position = new Vector3(-4f, 0f, -2f);
                    element.Size = new Vector3(4f, 12f, 4f);
                    element.UV = new Vector2(0f, 16f);
                    element.RotationOrigin = new Vector3(1.9f, 12f, 0f);
                })
                .AddElement("right_leg", element => {
                    element.Position = new Vector3(0f, 0f, -2f);
                    element.Size = new Vector3(4f, 12f, 4f);
                    element.UV = new Vector2(0f, 16f);
                    element.RotationOrigin = new Vector3(-1.9f, 12f, 0f);
                });
        }
    }
}
