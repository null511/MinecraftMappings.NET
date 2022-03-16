using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Trident : JavaEntityModel
    {
        public Trident() : base("Trident")
        {
            AddVersion("trident", "1.0.0")
                .WithTextureSize(32, 32)
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -27f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1.5f, 25f, -0.5f),
                        Size = new Vector3(3f, 2f, 1f),
                        UV = new Vector2(4f, 0f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-0.5f, 0f, -0.5f),
                        Size = new Vector3(1f, 31f, 1f),
                        UV = new Vector2(0f, 0f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(1.5f, 26f, -0.5f),
                        Size = new Vector3(1f, 4f, 1f),
                        UV = new Vector2(4f, 3f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2.5f, 26f, -0.5f),
                        Size = new Vector3(1f, 4f, 1f),
                        UV = new Vector2(4f, 3f),
                    });
                });
        }
    }
}
