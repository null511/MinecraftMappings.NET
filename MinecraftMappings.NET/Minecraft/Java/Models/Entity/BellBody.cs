using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class BellBody : JavaEntityModel
    {
        public BellBody() : base("Bell Body")
        {
            AddVersion("bell_body", "1.0.0")
                .WithTextureSize(32, 32)
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -12f, 0f);
                    element.RotationAngleX = -180;
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3f, 11f, -3f),
                        Size = new Vector3(6f, 7f, 6f),
                        UV = Vector2.Zero,
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 18f, -4f),
                        Size = new Vector3(8f, 2f, 8f),
                        UV = new Vector2(0f, 13f),
                    });
                });
        }
    }
}
