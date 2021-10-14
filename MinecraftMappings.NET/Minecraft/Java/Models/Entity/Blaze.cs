using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Blaze : JavaEntityModel
    {
        public Blaze() : base("Blaze")
        {
            AddVersion("blaze", "1.0.0")
                //.WithPath("entity")
                .WithTextureSize(64, 32)
                .AddElement("head", element => {
                    element.Position = new Vector3(-4f, 20f, -4f);
                    element.Size = new Vector3(8f, 8f, 8f);
                    element.UV = new Vector2(0f, 0f);
                    element.RotationOrigin = new Vector3(0f, 24f, 0f);
                })
                .AddElement("stick1", element => {
                    element.Position = new Vector3(6f, 18f, -8f);
                    element.Size = new Vector3(2f, 8f, 2f);
                    element.UV = new Vector2(0f, 16f);
                    element.RotationOrigin = new Vector3(-7f, 26f, -7f);
                })
                .AddElement("stick2", element => {
                    element.Position = new Vector3(-8f, 18f, -8f);
                    element.Size = new Vector3(2f, 8f, 2f);
                    element.UV = new Vector2(0f, 16f);
                    element.RotationOrigin = new Vector3(-7f, 26f, -7f);
                })
                .AddElement("stick3", element => {
                    element.Position = new Vector3(-8f, 18f, 6f);
                    element.Size = new Vector3(2f, 8f, 2f);
                    element.UV = new Vector2(0f, 16f);
                    element.RotationOrigin = new Vector3(7f, 26f, 7f);
                })
                .AddElement("stick4", element => {
                    element.Position = new Vector3(6f, 18f, 6f);
                    element.Size = new Vector3(2f, 8f, 2f);
                    element.UV = new Vector2(0f, 16f);
                    element.RotationOrigin = new Vector3(-7f, 26f, 7f);
                })
                .AddElement("stick5", element => {
                    element.Position = new Vector3(4f, 14f, -6f);
                    element.Size = new Vector3(2f, 8f, 2f);
                    element.UV = new Vector2(0f, 16f);
                    element.RotationOrigin = new Vector3(-5f, 22f, -5f);
                })
                .AddElement("stick6", element => {
                    element.Position = new Vector3(-6f, 14f, -6f);
                    element.Size = new Vector3(2f, 8f, 2f);
                    element.UV = new Vector2(0f, 16f);
                    element.RotationOrigin = new Vector3(5f, 22f, -5f);
                })
                .AddElement("stick7", element => {
                    element.Position = new Vector3(-6f, 14f, 4f);
                    element.Size = new Vector3(2f, 8f, 2f);
                    element.UV = new Vector2(0f, 16f);
                    element.RotationOrigin = new Vector3(5f, 22f, 5f);
                })
                .AddElement("stick8", element => {
                    element.Position = new Vector3(4f, 14f, 4f);
                    element.Size = new Vector3(2f, 8f, 2f);
                    element.UV = new Vector2(0f, 16f);
                    element.RotationOrigin = new Vector3(-5f, 22f, 5f);
                })
                .AddElement("stick9", element => {
                    element.Position = new Vector3(2f, 6f, -4f);
                    element.Size = new Vector3(2f, 8f, 2f);
                    element.UV = new Vector2(0f, 16f);
                    element.RotationOrigin = new Vector3(-3f, 14f, -3f);
                })
                .AddElement("stick10", element => {
                    element.Position = new Vector3(-4f, 6f, -4f);
                    element.Size = new Vector3(2f, 8f, 2f);
                    element.UV = new Vector2(0f, 16f);
                    element.RotationOrigin = new Vector3(3f, 14f, -3f);
                })
                .AddElement("stick11", element => {
                    element.Position = new Vector3(-4f, 6f, 2f);
                    element.Size = new Vector3(2f, 8f, 2f);
                    element.UV = new Vector2(0f, 16f);
                    element.RotationOrigin = new Vector3(3f, 14f, 3f);
                })
                .AddElement("stick12", element => {
                    element.Position = new Vector3(2f, 6f, 2f);
                    element.Size = new Vector3(2f, 8f, 2f);
                    element.UV = new Vector2(0f, 16f);
                    element.RotationOrigin = new Vector3(-3f, 14f, 3f);
                });
        }
    }
}
