using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Chest : JavaEntityModel
    {
        public Chest() : base("Chest")
        {
            AddVersion("chest", "1.0.0")
                //.WithPath("entity/bed")
                .WithTextureSize(64, 64)
                .AddElement("base", element => {
                    element.Position = new Vector3(-7f, 4f, -7f);
                    element.Size = new Vector3(14f, 10f, 14f);
                    element.UV = new Vector2(0f, 19f);
                    element.RotationOrigin = new Vector3(0f, 7f, 0f);
                    element.RotationAngleX = 180;
                })
                .AddElement("lid", element => {
                    element.Position = new Vector3(-7f, 0f, -7f);
                    element.Size = new Vector3(14f, 5f, 14f);
                    element.UV = new Vector2(0f, 0f);
                    element.RotationOrigin = new Vector3(0f, 7f, 0f);
                    element.RotationAngleX = 180;
                })
                .AddElement("knob", element => {
                    element.Position = new Vector3(-1f, 3f, 7f);
                    element.Size = new Vector3(2f, 4f, 1f);
                    element.UV = new Vector2(0f, 0f);
                    element.RotationOrigin = new Vector3(0f, 7f, 0f);
                    element.RotationAngleX = 180;
                });
        }
    }
}
