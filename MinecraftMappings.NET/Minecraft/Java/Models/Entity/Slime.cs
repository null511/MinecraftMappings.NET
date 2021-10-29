using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Slime : JavaEntityModel
    {
        public Slime() : base("Slime")
        {
            AddVersion("slime", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("body", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-3f, 1f, -3f),
                        Size = new Vector3(6f, 6f, 6f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("right_eye", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-3.3f, 4f, -3.5f),
                        Size = new Vector3(2f, 2f, 2f),
                        UV = new Vector2(32f, 0f),
                    });
                })
                .AddElement("left_eye", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(1.3f, 4f, -3.5f),
                        Size = new Vector3(2f, 2f, 2f),
                        UV = new Vector2(32f, 4f),
                    });
                })
                .AddElement("mouth", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 2f, -3.5f),
                        Size = new Vector3(1f, 1f, 1f),
                        UV = new Vector2(32f, 8f),
                    });
                });
        }
    }
}
